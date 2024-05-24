namespace HospitalManagementSystem
{
    partial class Patient
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
            TBPatDisease = new TextBox();
            label8 = new Label();
            CBPatGender = new ComboBox();
            TBPatAge = new TextBox();
            TBPatLastN = new TextBox();
            TBPatFirstN = new TextBox();
            TBPatID = new TextBox();
            BTNPatReset = new Label();
            BTNPatUpdate = new Label();
            BTNPatDelete = new Label();
            BTNPatAdd = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ListBoxPatients = new ListBox();
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
            panel4.Controls.Add(TBPatDisease);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(CBPatGender);
            panel4.Controls.Add(TBPatAge);
            panel4.Controls.Add(TBPatLastN);
            panel4.Controls.Add(TBPatFirstN);
            panel4.Controls.Add(TBPatID);
            panel4.Controls.Add(BTNPatReset);
            panel4.Controls.Add(BTNPatUpdate);
            panel4.Controls.Add(BTNPatDelete);
            panel4.Controls.Add(BTNPatAdd);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(ListBoxPatients);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(194, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1080, 681);
            panel4.TabIndex = 6;
            // 
            // TBPatDisease
            // 
            TBPatDisease.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBPatDisease.Location = new Point(688, 479);
            TBPatDisease.Name = "TBPatDisease";
            TBPatDisease.Size = new Size(284, 27);
            TBPatDisease.TabIndex = 38;
            TBPatDisease.TextChanged += TBPatDisease_TextChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(601, 468);
            label8.Name = "label8";
            label8.Size = new Size(81, 44);
            label8.TabIndex = 37;
            label8.Text = "DISEASE:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBPatGender
            // 
            CBPatGender.DropDownStyle = ComboBoxStyle.DropDownList;
            CBPatGender.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CBPatGender.FormattingEnabled = true;
            CBPatGender.Items.AddRange(new object[] { "", "Male", "Female", "Others", "Preffer Not To Say" });
            CBPatGender.Location = new Point(684, 433);
            CBPatGender.Name = "CBPatGender";
            CBPatGender.Size = new Size(209, 28);
            CBPatGender.TabIndex = 36;
            // 
            // TBPatAge
            // 
            TBPatAge.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBPatAge.Location = new Point(656, 392);
            TBPatAge.Name = "TBPatAge";
            TBPatAge.Size = new Size(67, 27);
            TBPatAge.TabIndex = 35;
            // 
            // TBPatLastN
            // 
            TBPatLastN.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBPatLastN.Location = new Point(168, 435);
            TBPatLastN.Name = "TBPatLastN";
            TBPatLastN.Size = new Size(262, 27);
            TBPatLastN.TabIndex = 34;
            TBPatLastN.TextChanged += TBPatLastN_TextChanged;
            // 
            // TBPatFirstN
            // 
            TBPatFirstN.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBPatFirstN.Location = new Point(168, 479);
            TBPatFirstN.Name = "TBPatFirstN";
            TBPatFirstN.Size = new Size(262, 27);
            TBPatFirstN.TabIndex = 33;
            TBPatFirstN.TextChanged += TBPatFirstN_TextChanged;
            // 
            // TBPatID
            // 
            TBPatID.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBPatID.Location = new Point(112, 392);
            TBPatID.Name = "TBPatID";
            TBPatID.Size = new Size(191, 27);
            TBPatID.TabIndex = 32;
            TBPatID.TextChanged += TBPatID_TextChanged;
            // 
            // BTNPatReset
            // 
            BTNPatReset.BackColor = Color.MistyRose;
            BTNPatReset.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNPatReset.ForeColor = SystemColors.ActiveCaptionText;
            BTNPatReset.Location = new Point(833, 567);
            BTNPatReset.Name = "BTNPatReset";
            BTNPatReset.Size = new Size(145, 46);
            BTNPatReset.TabIndex = 31;
            BTNPatReset.Text = "RESET";
            BTNPatReset.TextAlign = ContentAlignment.MiddleCenter;
            BTNPatReset.Click += BTNPatReset_Click;
            // 
            // BTNPatUpdate
            // 
            BTNPatUpdate.BackColor = Color.MistyRose;
            BTNPatUpdate.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNPatUpdate.ForeColor = SystemColors.ActiveCaptionText;
            BTNPatUpdate.Location = new Point(606, 567);
            BTNPatUpdate.Name = "BTNPatUpdate";
            BTNPatUpdate.Size = new Size(145, 46);
            BTNPatUpdate.TabIndex = 30;
            BTNPatUpdate.Text = "UPDATE";
            BTNPatUpdate.TextAlign = ContentAlignment.MiddleCenter;
            BTNPatUpdate.Click += BTNPatUpdate_Click;
            // 
            // BTNPatDelete
            // 
            BTNPatDelete.BackColor = Color.MistyRose;
            BTNPatDelete.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNPatDelete.ForeColor = SystemColors.ActiveCaptionText;
            BTNPatDelete.Location = new Point(321, 567);
            BTNPatDelete.Name = "BTNPatDelete";
            BTNPatDelete.Size = new Size(145, 46);
            BTNPatDelete.TabIndex = 29;
            BTNPatDelete.Text = "DELETE";
            BTNPatDelete.TextAlign = ContentAlignment.MiddleCenter;
            BTNPatDelete.Click += BTNPatDelete_Click;
            // 
            // BTNPatAdd
            // 
            BTNPatAdd.BackColor = Color.MistyRose;
            BTNPatAdd.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNPatAdd.ForeColor = SystemColors.ActiveCaptionText;
            BTNPatAdd.Location = new Point(98, 567);
            BTNPatAdd.Name = "BTNPatAdd";
            BTNPatAdd.Size = new Size(145, 46);
            BTNPatAdd.TabIndex = 28;
            BTNPatAdd.Text = "ADD";
            BTNPatAdd.TextAlign = ContentAlignment.MiddleCenter;
            BTNPatAdd.Click += BTNPatAdd_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(605, 383);
            label7.Name = "label7";
            label7.Size = new Size(45, 44);
            label7.TabIndex = 27;
            label7.Text = "AGE:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(601, 424);
            label6.Name = "label6";
            label6.Size = new Size(77, 44);
            label6.TabIndex = 26;
            label6.Text = "GENDER:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(70, 470);
            label5.Name = "label5";
            label5.Size = new Size(98, 44);
            label5.TabIndex = 25;
            label5.Text = "FIRSTNAME:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(70, 426);
            label4.Name = "label4";
            label4.Size = new Size(92, 44);
            label4.TabIndex = 24;
            label4.Text = "LASTNAME:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 385);
            label3.Name = "label3";
            label3.Size = new Size(36, 44);
            label3.TabIndex = 23;
            label3.Text = "ID:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ListBoxPatients
            // 
            ListBoxPatients.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxPatients.FormattingEnabled = true;
            ListBoxPatients.ItemHeight = 22;
            ListBoxPatients.Location = new Point(17, 70);
            ListBoxPatients.Name = "ListBoxPatients";
            ListBoxPatients.Size = new Size(1043, 268);
            ListBoxPatients.TabIndex = 22;
            ListBoxPatients.SelectedIndexChanged += ListBoxPatients_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(899, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 3);
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
            label1.Location = new Point(888, 11);
            label1.Name = "label1";
            label1.Size = new Size(180, 41);
            label1.TabIndex = 2;
            label1.Text = "PATIENTS";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1274, 679);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private ComboBox CBPatGender;
        private TextBox TBPatAge;
        private TextBox TBPatLastN;
        private TextBox TBPatFirstN;
        private TextBox TBPatID;
        private Label BTNPatReset;
        private Label BTNPatUpdate;
        private Label BTNPatDelete;
        private Label BTNPatAdd;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListBox ListBoxPatients;
        private TextBox TBPatDisease;
        private Label label8;
    }
}