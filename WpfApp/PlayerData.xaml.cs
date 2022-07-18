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
    /// Interaction logic for PlayerData.xaml
    /// </summary>
    public partial class PlayerData : Window
    {
        Player player = new Player();
        public PlayerData(Player player)
        {
            this.player = player;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            lblName.Content = player.Name;
            lblShirtNumber.Content = player.ShirtNumber;
            lblShirtNumber.Content = player.ShirtNumber;
            lblYellowCards.Content = player.Cards;
            lblPosition.Content = player.Position;
            lblGoals.Content = player.Goals;
            lblCaptain.Content = player.Captain ? "Yes" : "Not captain";
        }
    }
}
