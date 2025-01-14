namespace War_Machine_Project
{
    partial class Choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose));
            CarSelect = new PictureBox();
            TankSelect = new PictureBox();
            Tir1 = new PictureBox();
            Tir2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CarSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TankSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tir1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tir2).BeginInit();
            SuspendLayout();
            // 
            // CarSelect
            // 
            CarSelect.BackColor = Color.Transparent;
            CarSelect.Image = (Image)resources.GetObject("CarSelect.Image");
            CarSelect.Location = new Point(34, 153);
            CarSelect.Name = "CarSelect";
            CarSelect.Size = new Size(235, 212);
            CarSelect.SizeMode = PictureBoxSizeMode.Zoom;
            CarSelect.TabIndex = 0;
            CarSelect.TabStop = false;
            CarSelect.Click += CarSelect_Click;
            // 
            // TankSelect
            // 
            TankSelect.BackColor = Color.Transparent;
            TankSelect.Image = (Image)resources.GetObject("TankSelect.Image");
            TankSelect.Location = new Point(543, 168);
            TankSelect.Name = "TankSelect";
            TankSelect.Size = new Size(197, 176);
            TankSelect.SizeMode = PictureBoxSizeMode.Zoom;
            TankSelect.TabIndex = 1;
            TankSelect.TabStop = false;
            TankSelect.Click += TankSelect_Click;
            // 
            // Tir1
            // 
            Tir1.BackColor = Color.Transparent;
            Tir1.Image = (Image)resources.GetObject("Tir1.Image");
            Tir1.Location = new Point(86, 168);
            Tir1.Name = "Tir1";
            Tir1.Size = new Size(149, 191);
            Tir1.SizeMode = PictureBoxSizeMode.Zoom;
            Tir1.TabIndex = 2;
            Tir1.TabStop = false;
            Tir1.Visible = false;
            Tir1.Click += Tir1_Click;
            // 
            // Tir2
            // 
            Tir2.BackColor = Color.Transparent;
            Tir2.Image = (Image)resources.GetObject("Tir2.Image");
            Tir2.Location = new Point(587, 189);
            Tir2.Name = "Tir2";
            Tir2.Size = new Size(117, 143);
            Tir2.SizeMode = PictureBoxSizeMode.Zoom;
            Tir2.TabIndex = 3;
            Tir2.TabStop = false;
            Tir2.Visible = false;
            Tir2.Click += Tir2_Click;
            // 
            // Choose
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Tir2);
            Controls.Add(Tir1);
            Controls.Add(TankSelect);
            Controls.Add(CarSelect);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Choose";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseItem";
            ((System.ComponentModel.ISupportInitialize)CarSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)TankSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tir1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tir2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CarSelect;
        private PictureBox TankSelect;
        private PictureBox Tir1;
        private PictureBox Tir2;
    }
}