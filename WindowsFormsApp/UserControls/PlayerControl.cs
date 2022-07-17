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
        public bool isSelected = false;
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

        private void PlayerControl_MouseDown(object sender, MouseEventArgs e)
        {
            PlayerControl playerControl = sender as PlayerControl;
            if (e.Button == MouseButtons.Left)
            {
                playerControl.DoDragDrop(playerControl, DragDropEffects.Move);
                if (isSelected)
                {
                    pictureBoxStar.Visible = true;
                }
                else
                {
                    pictureBoxStar.Visible = false;
                }
            }
        }
    }
}
