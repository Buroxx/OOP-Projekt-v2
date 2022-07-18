using OOPLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        public Result result { get; set; }
        public Information(Result result)
        {
            InitializeComponent();
            this.result = result;
            LoadInfo();
        }

        private void LoadInfo()
        {
            lblCountry.Content = result.Country;
            lblCode.Content = result.FifaCode;
            lblGames.Content = result.GamesPlayed;
            lblWins.Content = result.Wins;
            lblDraws.Content = result.Draws;
            lblLosses.Content = result.Losses;
            lblGoalsFor.Content = result.GoalsFor;
            lblGoalsAgainst.Content = result.GoalsAgainst;
            lblGoalDifferential.Content = result.GoalDifferential;
        }
    }
}
