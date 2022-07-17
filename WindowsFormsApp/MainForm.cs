using OOPLib;
using OOPLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.UserControls;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<Player> players;
        private List<Match> matches;
        public List<string> favorites = new List<String>();
        public MainForm()
        {
            InitializeComponent();
            favorites = Repository.LoadFavorites();
            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            allPlayersPanel.Controls.Clear();
            favoritePlayersPanel.Controls.Clear();

            matches = await Repository.GetMatch();
            players = new List<Player>();

            foreach (Player player in matches[0].HomeTeamStatistics.StartingEleven)
            {
                players.Add(player);
            }
            foreach (Player player in matches[0].HomeTeamStatistics.Substitutes)
            {
                players.Add(player);
            }
            foreach (Player player in players)
            {
                bool used = false;

                foreach (string favorite in favorites)
                {
                    if (player.Name == favorite)
                    {
                        favoritePlayersPanel.Controls.Add(new PlayerControl(player, true));
                        used = true;
                    }
                }
                if (!used)
                {
                allPlayersPanel.Controls.Add(new PlayerControl(player, player.Favorite));
                }
            }
            foreach (Match match in matches)
            {
                foreach (TeamEvent teamEvent in match.HomeTeamEvents)
                {
                    AddGoalsCards(teamEvent, players);
                }
                foreach (TeamEvent teamEvent in match.AwayTeamEvents)
                {
                    AddGoalsCards(teamEvent, players);
                }
            }
        }

        private void AddGoalsCards(TeamEvent teamEvent, List<Player> players)
        {
            foreach (Player player in players)
            {
                if (player.Name.Equals(teamEvent.Player))
                {
                    if (teamEvent.TypeOfEvent.Equals("goal") || teamEvent.TypeOfEvent.Equals("goal-penalty"))
                    {
                        player.Goals += 1;
                    }
                    else if (teamEvent.TypeOfEvent.Equals("yellow-card"))
                    {
                        player.Cards += 1;
                    }
                }
            }
        }

        private void btnGoals_Click(object sender, EventArgs e)
        {
            if (players != null)
            {
                new Print(players, "Goals").ShowDialog();
            }
            else
            {
                MessageBox.Show("Players are empty");
            }
        }

        private void btnCards_Click(object sender, EventArgs e)
        {
            if (players != null)
            {
                new Print(players, "Cards").ShowDialog();
            }
            else
            {
                MessageBox.Show("Players are empty");
            }
        }

        private void btnVisitors_Click(object sender, EventArgs e)
        {
            if (players == null)
            {
                MessageBox.Show("Players are empty");
            }
            if (matches == null)
            {
                MessageBox.Show("Matches are empty");
            }
            new Print(matches).ShowDialog();
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            this.Hide();
            new Settings().Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Repository.SaveFavoritePlayers(favorites);
                Dispose();
             }
            else
            {
                return;
            }
        }

        private void allPlayersPanel_DragDrop(object sender, DragEventArgs e)
        {
            PlayerControl player = (PlayerControl)e.Data.GetData(typeof(PlayerControl));

            if (player.Parent == favoritePlayersPanel)
            {
                player.isSelected = false;
                allPlayersPanel.Controls.Add(player);

                favorites.Remove(player.player.Name);
            }
        }

        private void favoritePlayersPanel_DragDrop(object sender, DragEventArgs e)
        {
            PlayerControl player = (PlayerControl)e.Data.GetData(typeof(PlayerControl));

            if (player.Parent == allPlayersPanel && (favoritePlayersPanel.Controls.Count) < 3)
            {
                player.isSelected = true;
                favoritePlayersPanel.Controls.Add(player);

                favorites.Add(player.player.Name);
            }
        }

        private void allPlayersPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void favoritePlayersPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

    }
}
