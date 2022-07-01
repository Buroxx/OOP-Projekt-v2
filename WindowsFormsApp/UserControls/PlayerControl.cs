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
    public partial class PlayerControl : UserControl
    {
        public Player player;
        public PlayerControl()
        {
            InitializeComponent();
        }

        public PlayerControl(Player player, bool favorite)
        {
            InitializeComponent();
            this.player = player;
            lblName.Text = player.Name;
            lblPosition.Text = player.Position;
            lblNumber.Text = player.ShirtNumber.ToString();
            lblCaptain.Text = player.Captain ? "Captain" : "";
            if (favorite)
            {
                pictureBoxStar.Visible = true;
            }
        }






    }
}
