using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace War_Machine_Project
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void TankSelect_Click(object sender, EventArgs e)
        {
            TankSelect.Visible = false;
            CarSelect.Visible = false;
            this.BackgroundImage = Image.FromFile(@"Picture and sound  effect\\best background (428).jpg");
            Tir2.Visible = true;
            Tir1.Visible = true;
        }

        private void CarSelect_Click(object sender, EventArgs e)
        {
            TankSelect.Visible = false;
            CarSelect.Visible = false;
            this.BackgroundImage = Image.FromFile(@"Picture and sound  effect\\best background (428).jpg");
            Tir1.Visible = true;
            Tir2.Visible = true;
        }

        private void Tir2_Click(object sender, EventArgs e)
        {
            Game Runing = new Game();
            Runing.ShowDialog();
            this.Hide();
        }

        private void Tir1_Click(object sender, EventArgs e)
        {
            Game Runing = new Game();
            Runing.ShowDialog();
            this.Hide();
        }
        
    }
}
