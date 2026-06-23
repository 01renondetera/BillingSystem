namespace Billing_System
{
    partial class ChangePass
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
            lblChangePass = new Label();
            lblCurrentPass = new Label();
            txtCurrent = new TextBox();
            lblNewPass = new Label();
            txtNew = new TextBox();
            lblRetypePass = new Label();
            txtRetype = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            chkShowCurrent = new CheckBox();
            chkShowNew = new CheckBox();
            chkShowRetype = new CheckBox();
            SuspendLayout();
            // 
            // lblChangePass
            // 
            lblChangePass.AutoSize = true;
            lblChangePass.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangePass.Location = new Point(27, 40);
            lblChangePass.Name = "lblChangePass";
            lblChangePass.Size = new Size(181, 24);
            lblChangePass.TabIndex = 0;
            lblChangePass.Text = "Change Password";
            // 
            // lblCurrentPass
            // 
            lblCurrentPass.AutoSize = true;
            lblCurrentPass.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentPass.Location = new Point(27, 109);
            lblCurrentPass.Name = "lblCurrentPass";
            lblCurrentPass.Size = new Size(131, 17);
            lblCurrentPass.TabIndex = 1;
            lblCurrentPass.Text = "Current Password:";
            // 
            // txtCurrent
            // 
            txtCurrent.BorderStyle = BorderStyle.FixedSingle;
            txtCurrent.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrent.Location = new Point(158, 104);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.Size = new Size(232, 27);
            txtCurrent.TabIndex = 2;
            txtCurrent.UseSystemPasswordChar = true;
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPass.Location = new Point(27, 155);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(111, 17);
            lblNewPass.TabIndex = 3;
            lblNewPass.Text = "New Password:";
            // 
            // txtNew
            // 
            txtNew.BorderStyle = BorderStyle.FixedSingle;
            txtNew.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNew.Location = new Point(158, 151);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(232, 27);
            txtNew.TabIndex = 4;
            txtNew.UseSystemPasswordChar = true;
            // 
            // lblRetypePass
            // 
            lblRetypePass.AutoSize = true;
            lblRetypePass.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRetypePass.Location = new Point(27, 199);
            lblRetypePass.Name = "lblRetypePass";
            lblRetypePass.Size = new Size(128, 17);
            lblRetypePass.TabIndex = 5;
            lblRetypePass.Text = "Retype Password:";
            // 
            // txtRetype
            // 
            txtRetype.BorderStyle = BorderStyle.FixedSingle;
            txtRetype.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRetype.Location = new Point(158, 195);
            txtRetype.Name = "txtRetype";
            txtRetype.Size = new Size(232, 27);
            txtRetype.TabIndex = 6;
            txtRetype.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 255, 192);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(158, 263);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Password";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 192);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(323, 263);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(67, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkShowCurrent
            // 
            chkShowCurrent.Appearance = Appearance.Button;
            chkShowCurrent.AutoSize = true;
            chkShowCurrent.BackColor = Color.Transparent;
            chkShowCurrent.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowCurrent.Location = new Point(396, 104);
            chkShowCurrent.Name = "chkShowCurrent";
            chkShowCurrent.Size = new Size(36, 27);
            chkShowCurrent.TabIndex = 9;
            chkShowCurrent.Text = "👁";
            chkShowCurrent.TextAlign = ContentAlignment.MiddleCenter;
            chkShowCurrent.UseVisualStyleBackColor = false;
            chkShowCurrent.CheckedChanged += chkShowCurrent_CheckedChanged;
            // 
            // chkShowNew
            // 
            chkShowNew.Appearance = Appearance.Button;
            chkShowNew.AutoSize = true;
            chkShowNew.BackColor = Color.Transparent;
            chkShowNew.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowNew.Location = new Point(396, 151);
            chkShowNew.Name = "chkShowNew";
            chkShowNew.Size = new Size(36, 27);
            chkShowNew.TabIndex = 10;
            chkShowNew.Text = "👁";
            chkShowNew.TextAlign = ContentAlignment.MiddleCenter;
            chkShowNew.UseVisualStyleBackColor = false;
            chkShowNew.CheckedChanged += chkShowNew_CheckedChanged;
            // 
            // chkShowRetype
            // 
            chkShowRetype.Appearance = Appearance.Button;
            chkShowRetype.AutoSize = true;
            chkShowRetype.BackColor = Color.Transparent;
            chkShowRetype.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowRetype.Location = new Point(396, 195);
            chkShowRetype.Name = "chkShowRetype";
            chkShowRetype.Size = new Size(36, 27);
            chkShowRetype.TabIndex = 11;
            chkShowRetype.Text = "👁";
            chkShowRetype.TextAlign = ContentAlignment.MiddleCenter;
            chkShowRetype.UseVisualStyleBackColor = false;
            chkShowRetype.CheckedChanged += chkShowRetype_CheckedChanged;
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 344);
            Controls.Add(chkShowRetype);
            Controls.Add(chkShowNew);
            Controls.Add(chkShowCurrent);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtRetype);
            Controls.Add(lblRetypePass);
            Controls.Add(txtNew);
            Controls.Add(lblNewPass);
            Controls.Add(txtCurrent);
            Controls.Add(lblCurrentPass);
            Controls.Add(lblChangePass);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChangePass;
        private Label lblCurrentPass;
        private TextBox txtCurrent;
        private Label lblNewPass;
        private TextBox txtNew;
        private Label lblRetypePass;
        private TextBox txtRetype;
        private Button btnSave;
        private Button btnCancel;
        private CheckBox chkShowCurrent;
        private CheckBox chkShowNew;
        private CheckBox chkShowRetype;
    }
}