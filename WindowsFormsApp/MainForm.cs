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
        }
    }
}
