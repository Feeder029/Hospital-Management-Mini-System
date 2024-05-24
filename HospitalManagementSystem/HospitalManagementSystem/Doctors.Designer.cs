namespace HospitalManagementSystem
{
    partial class Doctors
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
            CBDocGender = new ComboBox();
            TBDocLicence = new TextBox();
            TBDocLastN = new TextBox();
            TBDocFirstN = new TextBox();
            TBDocID = new TextBox();
            BTNDocReset = new Label();
            BTNDocUpdate = new Label();
            BTNDocDelete = new Label();
            BTNDocAdd = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ListBoxDoctors = new ListBox();
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
            panel4.Controls.Add(CBDocGender);
            panel4.Controls.Add(TBDocLicence);
            panel4.Controls.Add(TBDocLastN);
            panel4.Controls.Add(TBDocFirstN);
            panel4.Controls.Add(TBDocID);
            panel4.Controls.Add(BTNDocReset);
            panel4.Controls.Add(BTNDocUpdate);
            panel4.Controls.Add(BTNDocDelete);
            panel4.Controls.Add(BTNDocAdd);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(ListBoxDoctors);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label1);
            panel4.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(194, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1080, 681);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // CBDocGender
            // 
            CBDocGender.DropDownStyle = ComboBoxStyle.DropDownList;
            CBDocGender.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CBDocGender.FormattingEnabled = true;
            CBDocGender.Items.AddRange(new object[] { "", "Male", "Female", "Others", "Preffer Not To Say" });
            CBDocGender.Location = new Point(690, 425);
            CBDocGender.Name = "CBDocGender";
            CBDocGender.Size = new Size(209, 28);
            CBDocGender.TabIndex = 21;
            // 
            // TBDocLicence
            // 
            TBDocLicence.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBDocLicence.Location = new Point(757, 467);
            TBDocLicence.Name = "TBDocLicence";
            TBDocLicence.Size = new Size(241, 27);
            TBDocLicence.TabIndex = 20;
            // 
            // TBDocLastN
            // 
            TBDocLastN.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBDocLastN.Location = new Point(168, 434);
            TBDocLastN.Name = "TBDocLastN";
            TBDocLastN.Size = new Size(262, 27);
            TBDocLastN.TabIndex = 19;
            // 
            // TBDocFirstN
            // 
            TBDocFirstN.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBDocFirstN.Location = new Point(168, 478);
            TBDocFirstN.Name = "TBDocFirstN";
            TBDocFirstN.Size = new Size(262, 27);
            TBDocFirstN.TabIndex = 18;
            // 
            // TBDocID
            // 
            TBDocID.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBDocID.Location = new Point(112, 391);
            TBDocID.Name = "TBDocID";
            TBDocID.Size = new Size(191, 27);
            TBDocID.TabIndex = 17;
            TBDocID.TextChanged += TBDocID_TextChanged;
            // 
            // BTNDocReset
            // 
            BTNDocReset.BackColor = Color.MistyRose;
            BTNDocReset.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNDocReset.ForeColor = SystemColors.ActiveCaptionText;
            BTNDocReset.Location = new Point(833, 566);
            BTNDocReset.Name = "BTNDocReset";
            BTNDocReset.Size = new Size(145, 46);
            BTNDocReset.TabIndex = 16;
            BTNDocReset.Text = "RESET";
            BTNDocReset.TextAlign = ContentAlignment.MiddleCenter;
            BTNDocReset.Click += BTNDocReset_Click;
            // 
            // BTNDocUpdate
            // 
            BTNDocUpdate.BackColor = Color.MistyRose;
            BTNDocUpdate.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNDocUpdate.ForeColor = SystemColors.ActiveCaptionText;
            BTNDocUpdate.Location = new Point(606, 566);
            BTNDocUpdate.Name = "BTNDocUpdate";
            BTNDocUpdate.Size = new Size(145, 46);
            BTNDocUpdate.TabIndex = 15;
            BTNDocUpdate.Text = "UPDATE";
            BTNDocUpdate.TextAlign = ContentAlignment.MiddleCenter;
            BTNDocUpdate.Click += BTNDocUpdate_Click;
            // 
            // BTNDocDelete
            // 
            BTNDocDelete.BackColor = Color.MistyRose;
            BTNDocDelete.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNDocDelete.ForeColor = SystemColors.ActiveCaptionText;
            BTNDocDelete.Location = new Point(321, 566);
            BTNDocDelete.Name = "BTNDocDelete";
            BTNDocDelete.Size = new Size(145, 46);
            BTNDocDelete.TabIndex = 14;
            BTNDocDelete.Text = "DELETE";
            BTNDocDelete.TextAlign = ContentAlignment.MiddleCenter;
            BTNDocDelete.Click += BTNDocDelete_Click;
            // 
            // BTNDocAdd
            // 
            BTNDocAdd.BackColor = Color.MistyRose;
            BTNDocAdd.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNDocAdd.ForeColor = SystemColors.ActiveCaptionText;
            BTNDocAdd.Location = new Point(98, 566);
            BTNDocAdd.Name = "BTNDocAdd";
            BTNDocAdd.Size = new Size(145, 46);
            BTNDocAdd.TabIndex = 13;
            BTNDocAdd.Text = "ADD";
            BTNDocAdd.TextAlign = ContentAlignment.MiddleCenter;
            BTNDocAdd.Click += BTNDocAdd_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(607, 460);
            label7.Name = "label7";
            label7.Size = new Size(144, 44);
            label7.TabIndex = 12;
            label7.Text = "LICENCE NUMBER:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(607, 416);
            label6.Name = "label6";
            label6.Size = new Size(77, 44);
            label6.TabIndex = 11;
            label6.Text = "GENDER:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(70, 469);
            label5.Name = "label5";
            label5.Size = new Size(98, 44);
            label5.TabIndex = 10;
            label5.Text = "FIRSTNAME:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(70, 425);
            label4.Name = "label4";
            label4.Size = new Size(92, 44);
            label4.TabIndex = 9;
            label4.Text = "LASTNAME:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 384);
            label3.Name = "label3";
            label3.Size = new Size(36, 44);
            label3.TabIndex = 8;
            label3.Text = "ID:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ListBoxDoctors
            // 
            ListBoxDoctors.FormattingEnabled = true;
            ListBoxDoctors.ItemHeight = 22;
            ListBoxDoctors.Location = new Point(17, 69);
            ListBoxDoctors.Name = "ListBoxDoctors";
            ListBoxDoctors.Size = new Size(1043, 290);
            ListBoxDoctors.TabIndex = 6;
            ListBoxDoctors.SelectedIndexChanged += ListBoxDoctors_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(903, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 3);
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
            label1.Location = new Point(894, 11);
            label1.Name = "label1";
            label1.Size = new Size(174, 41);
            label1.TabIndex = 2;
            label1.Text = "DOCTORS";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Doctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1274, 679);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctors";
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
        private ListBox ListBoxDoctors;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label BTNDocAdd;
        private TextBox TBDocLastN;
        private TextBox TBDocFirstN;
        private TextBox TBDocID;
        private Label BTNDocReset;
        private Label BTNDocUpdate;
        private Label BTNDocDelete;
        private ComboBox CBDocGender;
        private TextBox TBDocLicence;
    }
}