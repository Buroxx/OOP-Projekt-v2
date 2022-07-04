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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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
                allPlayersPanel.Controls.Add(new PlayerControl(player, player.Favorite));
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
    }
}
