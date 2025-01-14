namespace War_Machine_Project
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            label1 = new Label();
            BackToMenu = new Button();
            Restart = new Button();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Supercell-Magic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(190, 85);
            label1.Name = "label1";
            label1.Size = new Size(667, 118);
            label1.TabIndex = 0;
            label1.Text = "You Lose !!";
            // 
            // BackToMenu
            // 
            BackToMenu.BackColor = Color.Transparent;
            BackToMenu.FlatAppearance.BorderSize = 50;
            BackToMenu.Font = new Font("Supercell-Magic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            BackToMenu.ForeColor = Color.Black;
            BackToMenu.Location = new Point(225, 567);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new Size(587, 112);
            BackToMenu.TabIndex = 1;
            BackToMenu.Text = "Back To Home";
            BackToMenu.UseVisualStyleBackColor = false;
            BackToMenu.Click += BackToMenu_Click;
            // 
            // Restart
            // 
            Restart.BackColor = Color.Transparent;
            Restart.FlatAppearance.BorderSize = 50;
            Restart.Font = new Font("Supercell-Magic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Restart.ForeColor = Color.Black;
            Restart.Location = new Point(225, 449);
            Restart.Name = "Restart";
            Restart.Size = new Size(587, 112);
            Restart.TabIndex = 2;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = false;
            Restart.Click += Restart_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(225, 206);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(587, 237);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1006, 721);
            Controls.Add(pictureBox6);
            Controls.Add(Restart);
            Controls.Add(BackToMenu);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GameOver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameOver_WarMachine";
            Load += GameOver_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BackToMenu;
        private Button Restart;
        private PictureBox pictureBox6;
    }
}