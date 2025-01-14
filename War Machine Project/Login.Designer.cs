namespace War_Machine_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            username = new TextBox();
            pass = new TextBox();
            label1 = new Label();
            textUser = new Label();
            PassText = new Label();
            user = new RadioButton();
            Developer = new RadioButton();
            LOAD = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LOAD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.Font = new Font("Peyda", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(231, 134);
            username.Name = "username";
            username.Size = new Size(170, 31);
            username.TabIndex = 0;
            // 
            // pass
            // 
            pass.Font = new Font("Peyda", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pass.Location = new Point(232, 199);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.Size = new Size(170, 31);
            pass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Supercell-Magic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(147, 18);
            label1.Name = "label1";
            label1.Size = new Size(281, 58);
            label1.TabIndex = 2;
            label1.Text = "Welcome";
            // 
            // textUser
            // 
            textUser.AutoSize = true;
            textUser.BackColor = Color.Transparent;
            textUser.Font = new Font("Peyda", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            textUser.ForeColor = Color.White;
            textUser.Location = new Point(99, 134);
            textUser.Name = "textUser";
            textUser.Size = new Size(124, 32);
            textUser.TabIndex = 3;
            textUser.Text = "UserName :";
            // 
            // PassText
            // 
            PassText.AutoSize = true;
            PassText.BackColor = Color.Transparent;
            PassText.Font = new Font("Peyda", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            PassText.ForeColor = Color.White;
            PassText.Location = new Point(103, 199);
            PassText.Name = "PassText";
            PassText.Size = new Size(119, 32);
            PassText.TabIndex = 4;
            PassText.Text = "Password :";
            // 
            // user
            // 
            user.AutoSize = true;
            user.BackColor = Color.Transparent;
            user.Font = new Font("Peyda", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            user.ForeColor = Color.Transparent;
            user.Location = new Point(320, 266);
            user.Name = "user";
            user.Size = new Size(81, 36);
            user.TabIndex = 5;
            user.TabStop = true;
            user.Text = "User";
            user.UseVisualStyleBackColor = false;
            user.CheckedChanged += user_CheckedChanged;
            // 
            // Developer
            // 
            Developer.AutoSize = true;
            Developer.BackColor = Color.Transparent;
            Developer.Font = new Font("Peyda", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            Developer.ForeColor = Color.White;
            Developer.Location = new Point(167, 266);
            Developer.Name = "Developer";
            Developer.Size = new Size(135, 36);
            Developer.TabIndex = 6;
            Developer.TabStop = true;
            Developer.Text = "Developer";
            Developer.UseVisualStyleBackColor = false;
            Developer.CheckedChanged += Developer_CheckedChanged;
            // 
            // LOAD
            // 
            LOAD.BackColor = Color.Transparent;
            LOAD.Image = (Image)resources.GetObject("LOAD.Image");
            LOAD.Location = new Point(201, 212);
            LOAD.Name = "LOAD";
            LOAD.Size = new Size(176, 152);
            LOAD.SizeMode = PictureBoxSizeMode.Zoom;
            LOAD.TabIndex = 7;
            LOAD.TabStop = false;
            LOAD.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(529, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 453);
            Controls.Add(pictureBox1);
            Controls.Add(LOAD);
            Controls.Add(Developer);
            Controls.Add(user);
            Controls.Add(PassText);
            Controls.Add(textUser);
            Controls.Add(label1);
            Controls.Add(pass);
            Controls.Add(username);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)LOAD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox pass;
        private Label label1;
        private Label textUser;
        private Label PassText;
        private RadioButton user;
        private RadioButton Developer;
        private PictureBox LOAD;
        private PictureBox pictureBox1;
    }
}