using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace War_Machine_Project
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }
        //string atash = "Picture and sound  effect\\Dariush - Hasood.wav";
        string atash = "Picture and sound  effect\\ZARAR.wav";


        private void Restart_Click(object sender, EventArgs e)
        {
            string FileMusic = atash;
            SoundPlayer sound = new(FileMusic);
            sound.Stop();
            Game RUN = new Game();
            RUN.Show();
            this.Hide();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            string FileMusic = atash;
            SoundPlayer sound = new(FileMusic);
            sound.Stop();
            Menu Run = new Menu();
            Run.ShowDialog();
            this.Hide();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            string FileMusic = atash;
            SoundPlayer sound = new(FileMusic);
            sound.PlayLooping();
        }
    }
}
