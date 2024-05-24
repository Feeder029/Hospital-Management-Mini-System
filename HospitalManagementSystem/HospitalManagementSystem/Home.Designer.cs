namespace HospitalManagementSystem
{
    partial class Home
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
            panel4 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(194, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1080, 680);
            panel4.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(960, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 3);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Rockwell Extra Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(940, 11);
            label2.Name = "label2";
            label2.Size = new Size(128, 41);
            label2.TabIndex = 2;
            label2.Text = "HOME";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Rockwell Extra Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(940, 11);
            label1.Name = "label1";
            label1.Size = new Size(128, 41);
            label1.TabIndex = 2;
            label1.Text = "HOME";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1274, 679);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}