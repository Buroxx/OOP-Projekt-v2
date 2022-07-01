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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
           ddlChampionship.Items.Add("Male");
           ddlChampionship.Items.Add("Female");
           ddlChampionship.SelectedIndex = 0;

           ddlLanguage.Items.Add("English");
           ddlLanguage.Items.Add("Croatian");
           ddlLanguage.SelectedIndex = 0;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SettingsModel settings = new SettingsModel
            {
                Championship = ddlChampionship.Text,
                Language = ddlLanguage.Text
            };

            Repository.SaveSettings(settings);
            this.Hide();
            new FavoriteTeam().Show();
        }
    }
}
