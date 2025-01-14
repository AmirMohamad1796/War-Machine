using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace War_Machine_Project
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private async void Developer_CheckedChanged(object sender, EventArgs e)
        {
            if (Developer.Checked == true && username.Text == "MrBug" && pass.Text == "1796")
            {
                LOAD.Visible = true;
                await Task.Delay(2000);

                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = "https://github.com/AmirMohamad1796",
                    UseShellExecute = true
                };
                Process.Start(psInfo);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check The UserName And Password");
                Developer.Checked = false;
            }
        }

        private async void user_CheckedChanged(object sender, EventArgs e)
        {
            if (user.Checked == true)
            {
                pass.Hide();
                PassText.Hide();
                textUser.Hide();
                username.Hide();
                LOAD.Visible = true;
                await Task.Delay(2000);
                Menu RUN = new Menu();
                RUN.Show();
                this.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //string a = @"Picture and sound  effect\\GTA.wav";
            //SoundPlayer ask = new(a);
            //ask.Play();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
