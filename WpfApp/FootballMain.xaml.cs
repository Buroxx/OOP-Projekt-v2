using OOPLib;
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
    /// Interaction logic for FootballMain.xaml
    /// </summary>
    public partial class FootballMain : Window
    {
        HashSet<Match> matches = new HashSet<Match>();
        HashSet<Result> results = new HashSet<Result>();
        HashSet<Player> startingEleven = new HashSet<Player>();
        string pickedCountry;
        string fifa_code;
        string oponentCountry;

        Result country = new Result();

        public FootballMain()
        {
            Init();
            InitializeComponent();
            LoadResolution();
        }

        private void Init()
        {
            FillTeamData();
        }

        private void LoadResolution()
        {
            string picked = Repository.GetWPFResolution();

            switch (picked)
            {
                case "Small":
                    Width = 800;
                    Height = 850;
                    break;
                case "Medium":
                    Width = 1100;
                    Height = 900;
                    break;
                case "Large":
                    Width = 1200;
                    Height = 1000;
                    break;
                default:
                    break;
            }
        }

        private async void FillTeamData()
        {
            results = await Repository.LoadMatchResults();

            foreach (var result in results)
            {
                cbHomeTeam.Items.Add(result);
            }

        }

        private void cbHomeTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbOppositeTeam.Items.Clear();
            string data = cbHomeTeam.SelectedItem.ToString();
            string[] details = data.Split('(');
            string newTeam = details[1].Substring(0, 3);
            pickedCountry = details[0];
            fifa_code = newTeam;
            Repository.SaveWPFFavoriteTeam(new WPFSettings(newTeam));
            LoadOppositeTeam();
        }

        private async void LoadOppositeTeam()
        {
            matches = await Repository.LoadMatches(fifa_code);

            foreach (var match in matches)
            {
                if (match.HomeTeamCountry == pickedCountry.Trim())
                {
                    cbOppositeTeam.Items.Add(match.AwayTeamCountry);
                }
            }

            foreach (var match in matches)
            {
                if (match.AwayTeamCountry == pickedCountry.Trim())
                {
                    cbOppositeTeam.Items.Add(match.HomeTeamCountry);
                }
            }


        }

        private void cbOppositeTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbOppositeTeam.SelectedItem == null)
            {
                return;
            }

            oponentCountry = cbOppositeTeam.SelectedItem.ToString();

            GetScore();
            LoadHomeTeam();
            LoadAwayTeam();


        }

        private void LoadHomeTeam()
        {
            homeGoal.Children.Clear();
            homeDefender.Children.Clear();
            homeForward.Children.Clear();
            homeMid.Children.Clear();

            foreach (var match in matches)
            {
                if (match.HomeTeamCountry == pickedCountry.Trim())
                {
                    startingEleven = new HashSet<Player>();

                    foreach (var item in match.HomeTeamStatistics.StartingEleven)
                    {
                        startingEleven.Add(item);
                    }
                    foreach (TeamEvent eevent in match.HomeTeamEvents)
                    {
                        AddGoalsCards(eevent, startingEleven);
                    }
                }
            }
            DisplayHomeTeam();
        }

        private void DisplayHomeTeam()
        {
            foreach (var player in startingEleven)
            {
                switch (player.Position)
                {
                    case "Goalie":
                        homeGoal.Children.Add(new PlayerControl(player));
                        break;
                    case "Defender":
                        homeDefender.Children.Add(new PlayerControl(player));
                        break;
                    case "Midfield":
                        homeMid.Children.Add(new PlayerControl(player));
                        break;
                    case "Forward":
                        homeForward.Children.Add(new PlayerControl(player));
                        break;
                    default:
                        break;
                }
            }
        }

        private void LoadAwayTeam()
        {
            oppositeGoal.Children.Clear();
            oppositeDefender.Children.Clear();
            oppositeMid.Children.Clear();
            oppositeForward.Children.Clear();

            foreach (var match in matches)
            {
                if (match.AwayTeamCountry == oponentCountry)
                {
                    startingEleven = new HashSet<Player>();

                    foreach (var player in match.AwayTeamStatistics.StartingEleven)
                    {
                        startingEleven.Add(player);
                    }

                    foreach (TeamEvent eevent in match.AwayTeamEvents)
                    {
                        AddGoalsCards(eevent, startingEleven);
                    }

                }
            }
            DisplayOponentTeam();
        }

        private void AddGoalsCards(TeamEvent teamEvent, HashSet<Player> startingEleven)
        {
            foreach (var player in startingEleven)
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

            private void DisplayOponentTeam()
            {
                foreach (var player in startingEleven)
                {
                    switch (player.Position)
                    {
                        case "Goalie":
                            oppositeGoal.Children.Add(new PlayerControl(player));
                            break;
                        case "Defender":
                            oppositeDefender.Children.Add(new PlayerControl(player));
                            break;
                        case "Midfield":
                            oppositeMid.Children.Add(new PlayerControl(player));
                            break;
                        case "Forward":
                            oppositeForward.Children.Add(new PlayerControl(player));
                            break;
                        default:
                            break;
                    }
                }
            }

            private void GetScore()
            {
                foreach (var item in matches)
                {
                    if (pickedCountry.Trim() == item.HomeTeamCountry)
                    {
                        lblResult.Content = $"{item.HomeTeam.Goals} : {item.AwayTeam.Goals}";
                    }
                }
            }

            private void btnHomeTeam_Click(object sender, RoutedEventArgs e)
            {
                foreach (var result in results)
                {
                    if (result.Country == pickedCountry.Trim())
                    {
                        country = result;
                    }
                }
                new Information(country).Show();
            }

            private void btnSettings_Click(object sender, RoutedEventArgs e)
            {
                this.Hide();
                new MainWindow().Show();
            }

            private void btnOpposite_Click(object sender, RoutedEventArgs e)
            {
                country = new Result();

                foreach (var result in results)
                {
                    if (result.Country == oponentCountry)
                    {
                        country = result;
                    }
                }

                new Information(country).Show();
            }

            private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
            {
                Application.Current.Shutdown();
            }
        }
    }
