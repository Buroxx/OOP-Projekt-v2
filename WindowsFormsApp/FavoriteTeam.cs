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

namespace WindowsFormsApp
{
    public partial class FavoriteTeam : Form
    {
        List<Team> teams = new List<Team>();
        public FavoriteTeam()
        {
            InitializeComponent();
        }

        private void FavoriteTeam_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            teams = await Repository.GetTeam(); 
            foreach (Team team in teams)
            {
                ddlTeam.Items.Add(team);
            }
            ddlTeam.SelectedIndex = 0;
        }

        private void btnPickTeam_Click(object sender, EventArgs e)
        {
            Team selectedTeam = ddlTeam.SelectedItem as Team;
            Repository.SaveFavoriteTeam(selectedTeam);
            this.Hide();
            new MainForm().Show();
        }
    }
}
