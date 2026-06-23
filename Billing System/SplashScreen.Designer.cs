namespace Billing_System
{
    partial class SplashScreen
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
            lblAppName = new Label();
            lblTagline = new Label();
            splashTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(65, 38);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(378, 72);
            lblAppName.TabIndex = 0;
            lblAppName.Text = " BILLING SYSTEM";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            lblAppName.Click += lblAppName_Click;
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.FromArgb(189, 215, 238);
            lblTagline.Location = new Point(115, 100);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(283, 21);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Water Billing Management System";
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splashTimer
            // 
            splashTimer.Interval = 2500;
            splashTimer.Tick += splashTimer_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(lblTagline);
            Controls.Add(lblAppName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += SplashScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private Label lblTagline;
        private System.Windows.Forms.Timer splashTimer;
    }
}