namespace War_Machine_Project
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            Createdby = new Label();
            BtnExit = new Label();
            BtnStart = new Label();
            SuspendLayout();
            // 
            // Createdby
            // 
            resources.ApplyResources(Createdby, "Createdby");
            Createdby.BackColor = Color.Transparent;
            Createdby.ForeColor = Color.Black;
            Createdby.Name = "Createdby";
            // 
            // BtnExit
            // 
            resources.ApplyResources(BtnExit, "BtnExit");
            BtnExit.BackColor = Color.Transparent;
            BtnExit.ForeColor = Color.White;
            BtnExit.Name = "BtnExit";
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnStart
            // 
            resources.ApplyResources(BtnStart, "BtnStart");
            BtnStart.BackColor = Color.Transparent;
            BtnStart.ForeColor = Color.White;
            BtnStart.Name = "BtnStart";
            BtnStart.Click += BtnStart_Click;
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Createdby);
            Controls.Add(BtnExit);
            Controls.Add(BtnStart);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Menu";
            SizeGripStyle = SizeGripStyle.Show;
            FormClosed += Menu_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Createdby;
        private Label BtnExit;
        private Label BtnStart;
    }
}
