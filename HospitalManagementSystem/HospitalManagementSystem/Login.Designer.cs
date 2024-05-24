namespace HospitalManagementSystem
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
            label1 = new Label();
            TBUser = new TextBox();
            TBPass = new TextBox();
            label4 = new Label();
            label2 = new Label();
            BTNLogin = new Label();
            CBShowpass = new CheckBox();
            BTNQuit = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Snow;
            label1.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(93, 33);
            label1.Name = "label1";
            label1.Size = new Size(346, 62);
            label1.TabIndex = 2;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM NI DOCTOR REVEN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBUser
            // 
            TBUser.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TBUser.Location = new Point(120, 156);
            TBUser.Name = "TBUser";
            TBUser.Size = new Size(294, 35);
            TBUser.TabIndex = 33;
            TBUser.TextChanged += TBUser_TextChanged;
            // 
            // TBPass
            // 
            TBPass.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TBPass.Location = new Point(120, 242);
            TBPass.Name = "TBPass";
            TBPass.Size = new Size(294, 35);
            TBPass.TabIndex = 34;
            TBPass.UseSystemPasswordChar = true;
            TBPass.TextChanged += TBPass_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(120, 133);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 35;
            label4.Text = "USERNAME:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(120, 220);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 36;
            label2.Text = "PASSWORD:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BTNLogin
            // 
            BTNLogin.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BTNLogin.ForeColor = Color.DarkGreen;
            BTNLogin.Location = new Point(120, 319);
            BTNLogin.Name = "BTNLogin";
            BTNLogin.Size = new Size(145, 35);
            BTNLogin.TabIndex = 37;
            BTNLogin.Text = "LOGIN";
            BTNLogin.TextAlign = ContentAlignment.MiddleCenter;
            BTNLogin.Click += BTNLogin_Click;
            // 
            // CBShowpass
            // 
            CBShowpass.Font = new Font("Rockwell", 6F, FontStyle.Regular, GraphicsUnit.Point);
            CBShowpass.Location = new Point(290, 224);
            CBShowpass.Name = "CBShowpass";
            CBShowpass.Size = new Size(124, 17);
            CBShowpass.TabIndex = 38;
            CBShowpass.Text = "SHOW PASSWORD";
            CBShowpass.UseVisualStyleBackColor = true;
            CBShowpass.CheckedChanged += CBShowpass_CheckedChanged;
            // 
            // BTNQuit
            // 
            BTNQuit.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BTNQuit.ForeColor = Color.Red;
            BTNQuit.Location = new Point(271, 319);
            BTNQuit.Name = "BTNQuit";
            BTNQuit.Size = new Size(145, 35);
            BTNQuit.TabIndex = 39;
            BTNQuit.Text = "QUIT";
            BTNQuit.TextAlign = ContentAlignment.MiddleCenter;
            BTNQuit.Click += BTNQuit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(549, 388);
            Controls.Add(BTNQuit);
            Controls.Add(CBShowpass);
            Controls.Add(BTNLogin);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(TBPass);
            Controls.Add(TBUser);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBUser;
        private TextBox TBPass;
        private Label label4;
        private Label label2;
        private Label BTNLogin;
        private CheckBox CBShowpass;
        private Label BTNQuit;
    }
}