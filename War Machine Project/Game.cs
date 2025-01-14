using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Media;
using System.CodeDom.Compiler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Timers;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace War_Machine_Project
{
    public partial class Game : Form
    {
        int Score1 = 1;
        int SpeedBike = 15;
        int SpeedCar = 5;
        int sanie = 100;
        int hp = 3;

        PictureBox TIR = new PictureBox();

        bool Cheat = true;

        public Game()
        {
            InitializeComponent();
        }

        //Timers Respwan Enemi MotorCyclet
        private async void timerMotor_Tick(object sender, EventArgs e)
        {
            if (EnemiBike1.Location.Y >= 760 || EnemiBike1.Bounds.IntersectsWith(PlayerTank.Bounds) || TIR.Bounds.IntersectsWith(EnemiBike1.Bounds))
            {
                Random rnd = new Random();
                EnemiBike1.Location = new Point(rnd.Next(180, 800), 0);
            }

            EnemiBike1.Location = new Point(EnemiBike1.Location.X, EnemiBike1.Location.Y + SpeedBike);
            
            if (ADDJON.Bounds.IntersectsWith(PlayerTank.Bounds) && Health.Text == "* 1")
            {
                Health.Text = "* 2";

            }
            else if (ADDJON.Bounds.IntersectsWith(PlayerTank.Bounds) && Health.Text == "* 2")
            {
                Health.Text = "* 3";
            }

            if (TIR.Bounds.IntersectsWith(EnemiBike1.Bounds))
            {
                EnemiBike1.Image = Image.FromFile(@"Picture and sound  effect\\Bomb.png");
                await Task.Delay(450);
                EnemiBike1.Image = Image.FromFile(@"Picture and sound  effect\\Bike.png");
            }

            if (Cheat == true)
            {
                if (EnemiBike1.Bounds.IntersectsWith(PlayerTank.Bounds) && Health.Text == "* 3")
                {

                    Health.Text = "* 2";

                }
                else if (EnemiBike1.Bounds.IntersectsWith(PlayerTank.Bounds) && Health.Text == "* 2")
                {

                    Health.Text = "* 1";

                }
                else if (EnemiBike1.Bounds.IntersectsWith(PlayerTank.Bounds) && Health.Text == "* 1")
                {
                    Health.Text = "* 0";
                    EnemiCar1.Visible = false;
                    EnemiBike1.Visible = false;
                    PlayerTank.Visible = false;
                    timerMotor.Stop();
                    timer2.Stop();
                    Score.Stop();
                    khat.Stop();
                    GameOver RUN = new GameOver();
                    RUN.Show();
                    this.Hide();
                }
            }

        }
        //Timers Respwan Enemi Car
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (EnemiCar1.Location.Y >= 760 || EnemiCar1.Bounds.IntersectsWith(PlayerTank.Bounds) || TIR.Bounds.IntersectsWith(EnemiCar1.Bounds))
            {
                Random rnd = new Random();
                EnemiCar1.Location = new Point(rnd.Next(180, 800), 0);
            }

            EnemiCar1.Location = new Point(EnemiCar1.Location.X, EnemiCar1.Location.Y + SpeedCar);

            if (ADDJON.Bounds.IntersectsWith(PlayerTank.Bounds) && Health.Text == "* 1")
            {
                Health.Text = "* 2";
            }
            else if (ADDJON.Bounds.IntersectsWith(PlayerTank.Bounds) && Health.Text == "* 2")
            {
                Health.Text = "* 3";
            }

            if (Cheat == true)
            {
                if (EnemiCar1.Bounds.IntersectsWith(PlayerTank.Bounds) && Health.Text == "* 3")
                {
                    Health.Text = "* 2";
                }
                else if (EnemiCar1.Bounds.IntersectsWith(PlayerTank.Bounds) && Health.Text == "* 2")
                {
                    Health.Text = "* 1";
                }
                else if (EnemiCar1.Bounds.IntersectsWith(PlayerTank.Bounds) && Health.Text == "* 1")
                {
                    Health.Text = "* 0";
                    EnemiCar1.Visible = false;
                    EnemiBike1.Visible = false;
                    PlayerTank.Visible = false;
                    timerMotor.Stop();
                    timer2.Stop();
                    Score.Stop();
                    khat.Stop();
                    GameOver RUN = new GameOver();
                    RUN.Show();
                    this.Hide();
                }
            }
        }
        private void AddScore()
        {

            if (EnemiBike1.Location.Y > PlayerTank.Location.Y)
            {
                Score1++;
                TextScore.Text = Score1 + "";
            }
            if (EnemiCar1.Location.Y > PlayerTank.Location.Y)
            {
                Score1++;
                TextScore.Text = Score1 + "";
            }
        }

        //MOVE LEFT AND RIGHT
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                //Move Left and Right
                case Keys.Left:
                    if (PlayerTank.Location.X <= 180) return true;
                    PlayerTank.Location = new Point(PlayerTank.Location.X - 20, PlayerTank.Location.Y);
                    break;
                case Keys.Right:
                    if (PlayerTank.Location.X >= 800) return true;
                    PlayerTank.Location = new Point(PlayerTank.Location.X + 20, PlayerTank.Location.Y);
                    break;
                case Keys.A:
                    if (PlayerTank.Location.X <= 180) return true;
                    PlayerTank.Location = new Point(PlayerTank.Location.X - 20, PlayerTank.Location.Y);
                    break;
                case Keys.D:
                    if (PlayerTank.Location.X >= 800) return true;
                    PlayerTank.Location = new Point(PlayerTank.Location.X + 20, PlayerTank.Location.Y);
                    break;
                case Keys.Up:
                    MessageBox.Show("cheat is now on!!!");
                    PlayerTank.Image = Image.FromFile(@"Picture and sound  effect\\TankGOS.png");
                    Cheat = false;
                    break;
                case Keys.Down:
                    MessageBox.Show("cheat is now off");
                    PlayerTank.Image = Image.FromFile(@"Picture and sound  effect\\Tank.png");
                    Cheat = true;
                    break;
                case Keys.G:
                    string Bogh = @"bogh.wav";
                    SoundPlayer b = new(Bogh);
                    b.Play();
                    break;
                case Keys.Space:
                    string a = @"Rec 0004 (2) (2) - Copy.wav";
                    SoundPlayer ss = new(a);
                    ss.Play();
                    Thread sleepTir = new Thread(Tir);
                    sleepTir.Start();
                    //Tir();
                    break;
                default:
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Shelik Tir
        private void Tir()
        {

            TIR.BackColor = Color.Transparent;
            TIR.Size = new Size(15, 30);
            TIR.SizeMode = PictureBoxSizeMode.StretchImage;
            TIR.Image = Image.FromFile(@"Picture and sound  effect\\Tir.png");


            Invoke(new Action(() =>
            {
                TIR.Location = new Point(PlayerTank.Location.X + 43, PlayerTank.Location.Y - 1);
                this.Controls.Add(TIR);
            }));

            for (int i = 0; i < 35; i++)
            {
                Thread.Sleep(50);
                NewMethod();
            }
        }

        private void NewMethod()
        {
            Invoke(new Action(() =>
            {
                TIR.Location = new Point(TIR.Location.X, TIR.Location.Y - 20);

            }));
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Score_Tick(object sender, EventArgs e)
        {
            Score1++;
            TextScore.Text = Score1 + "";
        }

        private void khat_Tick(object sender, EventArgs e)
        {
            AddScore();
        }

        private void Speed_Tick(object sender, EventArgs e)
        {
            if (khat.Interval > 0)
            {
                khat.Interval -= 10;
            }
                SpeedCar += 2;
                SpeedBike += 2;
                string a = @"Picture and sound  effect\\neysan.wav";
                SoundPlayer ask = new(a);
                ask.Play(); 

            if (Score1 % 5 == 0)
            {
               SpeedBike += 2;
                string a1 = @"Picture and sound  effect\\neysan.wav";
                SoundPlayer ask1 = new(a1);
                ask1.Play();
            }
            if (Score1 % 5 == 0)
            {
                SpeedCar += 2;
                string a2 = @"Picture and sound  effect\\neysan.wav";
                SoundPlayer ask2 = new(a2);
                ask2.Play();
            }
        }

        private void jon_Tick(object sender, EventArgs e)
        {
            if (ADDJON.Location.Y >= 760 || ADDJON.Bounds.IntersectsWith(PlayerTank.Bounds))
            {
                Random rnd = new Random();
                ADDJON.Location = new Point(rnd.Next(180, 800), 0);
            }
            ADDJON.Location = new Point(ADDJON.Location.X, ADDJON.Location.Y + 15);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TIR.Bounds.IntersectsWith(EnemiCar1.Bounds))
            {
                Score1 += 2;
                TextScore.Text = Score1 + "";
            }
            if (TIR.Bounds.IntersectsWith(EnemiBike1.Bounds))
            {
                Score1 += 2;
                TextScore.Text = Score1 + "";
            }
        }
        private void Day_Night_Tick(object sender, EventArgs e)
        {
            if (Score1 % 20 == 0)
            {
                this.BackColor = Color.DarkSlateBlue;
            }
            if (Score1 % 40 == 0)
            {
                this.BackColor = Color.Silver;
            }

            if (Score1 % 60 == 0)
            {
                this.BackColor = Color.DarkSlateBlue;
            }

            if (Score1 % 80 == 0)
            {
                this.BackColor = Color.Silver;
            }

            if (Score1 % 100 == 0)
            {
                this.BackColor = Color.DarkSlateBlue;
            }
        }
    }
}
