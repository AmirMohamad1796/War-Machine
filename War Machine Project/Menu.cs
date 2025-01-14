using System.Media;

namespace War_Machine_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            Game RUN = new Game();
            RUN.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            string a = @"Picture and sound  effect\\GTA.wav";
            SoundPlayer login = new(a);
            login.Stop();
        }
    }
}
