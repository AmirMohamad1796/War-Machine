namespace War_Machine_Project
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            PlayerTank = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            timerMotor = new System.Windows.Forms.Timer(components);
            TextScore = new Label();
            Score = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            khat = new System.Windows.Forms.Timer(components);
            Health = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Speed = new System.Windows.Forms.Timer(components);
            Day_Night = new System.Windows.Forms.Timer(components);
            jon = new System.Windows.Forms.Timer(components);
            ADDJON = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            EnemiCar1 = new PictureBox();
            EnemiBike1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PlayerTank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ADDJON).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnemiCar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnemiBike1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // PlayerTank
            // 
            PlayerTank.BackColor = Color.Transparent;
            PlayerTank.Image = (Image)resources.GetObject("PlayerTank.Image");
            PlayerTank.Location = new Point(473, 627);
            PlayerTank.Name = "PlayerTank";
            PlayerTank.Size = new Size(90, 96);
            PlayerTank.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerTank.TabIndex = 4;
            PlayerTank.TabStop = false;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // timerMotor
            // 
            timerMotor.Enabled = true;
            timerMotor.Interval = 50;
            timerMotor.Tick += timerMotor_Tick;
            // 
            // TextScore
            // 
            TextScore.AutoSize = true;
            TextScore.BackColor = Color.Transparent;
            TextScore.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TextScore.ForeColor = Color.White;
            TextScore.Location = new Point(109, 4);
            TextScore.Name = "TextScore";
            TextScore.Size = new Size(33, 36);
            TextScore.TabIndex = 7;
            TextScore.Text = "1";
            // 
            // Score
            // 
            Score.Enabled = true;
            Score.Interval = 3000;
            Score.Tick += Score_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-3, 1);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 8;
            label1.Text = "Score : ";
            // 
            // khat
            // 
            khat.Enabled = true;
            khat.Interval = 500;
            khat.Tick += khat_Tick;
            // 
            // Health
            // 
            Health.AutoSize = true;
            Health.BackColor = Color.Transparent;
            Health.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Health.ForeColor = Color.White;
            Health.Location = new Point(56, 39);
            Health.Name = "Health";
            Health.Size = new Size(71, 46);
            Health.TabIndex = 9;
            Health.Text = "* 3";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 85;
            timer1.Tick += timer1_Tick;
            // 
            // Speed
            // 
            Speed.Enabled = true;
            Speed.Interval = 5000;
            Speed.Tick += Speed_Tick;
            // 
            // Day_Night
            // 
            Day_Night.Enabled = true;
            Day_Night.Interval = 50;
            Day_Night.Tick += Day_Night_Tick;
            // 
            // jon
            // 
            jon.Enabled = true;
            jon.Interval = 10;
            jon.Tick += jon_Tick;
            // 
            // ADDJON
            // 
            ADDJON.Image = (Image)resources.GetObject("ADDJON.Image");
            ADDJON.Location = new Point(492, -27);
            ADDJON.Name = "ADDJON";
            ADDJON.Size = new Size(38, 33);
            ADDJON.SizeMode = PictureBoxSizeMode.StretchImage;
            ADDJON.TabIndex = 11;
            ADDJON.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(157, -12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 744);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(872, -12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 744);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(343, -12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(90, 744);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(593, -12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(90, 744);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // EnemiCar1
            // 
            EnemiCar1.Image = (Image)resources.GetObject("EnemiCar1.Image");
            EnemiCar1.Location = new Point(223, -97);
            EnemiCar1.Name = "EnemiCar1";
            EnemiCar1.Size = new Size(114, 165);
            EnemiCar1.SizeMode = PictureBoxSizeMode.Zoom;
            EnemiCar1.TabIndex = 16;
            EnemiCar1.TabStop = false;
            // 
            // EnemiBike1
            // 
            EnemiBike1.Image = (Image)resources.GetObject("EnemiBike1.Image");
            EnemiBike1.Location = new Point(666, -125);
            EnemiBike1.Name = "EnemiBike1";
            EnemiBike1.Size = new Size(114, 165);
            EnemiBike1.SizeMode = PictureBoxSizeMode.Zoom;
            EnemiBike1.TabIndex = 17;
            EnemiBike1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-3, 149);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 18;
            label2.Text = "ADS :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(-3, 666);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 19;
            label3.Text = "انجام هرگونه تبلیغات \r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-3, 689);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 20;
            label4.Text = "@Pouriasuni";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(-3, 613);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 21;
            label5.Text = "دسترسی به گیف و استیکر";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(-3, 636);
            label6.Name = "label6";
            label6.Size = new Size(104, 23);
            label6.TabIndex = 22;
            label6.Text = "@afzali_gof";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1, 197);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(150, 289);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(-3, 492);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(154, 113);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 24;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(105, 632);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(35, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 25;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(105, 689);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(35, 33);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 26;
            pictureBox9.TabStop = false;
            // 
            // Game
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1006, 721);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(EnemiBike1);
            Controls.Add(EnemiCar1);
            Controls.Add(pictureBox1);
            Controls.Add(Health);
            Controls.Add(label1);
            Controls.Add(TextScore);
            Controls.Add(PlayerTank);
            Controls.Add(ADDJON);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarMachine";
            ((System.ComponentModel.ISupportInitialize)PlayerTank).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ADDJON).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnemiCar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnemiBike1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox PlayerTank;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerMotor;
        private Label TextScore;
        private System.Windows.Forms.Timer Score;
        private Label label1;
        private System.Windows.Forms.Timer khat;
        private Label Health;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer Speed;
        private System.Windows.Forms.Timer Day_Night;
        private System.Windows.Forms.Timer jon;
        private PictureBox ADDJON;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox EnemiCar1;
        private PictureBox EnemiBike1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
    }
}