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

namespace WindowsFormsApp.UserControls
{
    public partial class RankControl : UserControl
    {
        public RankControl()
        {
            InitializeComponent();
        }
        
        public RankControl(Player player)
        {
            InitializeComponent();
            lblName.Text = player.Name;
            lblGoals.Text = player.Goals.ToString();
            lblCards.Text = player.Cards.ToString();
        }
    }
}
