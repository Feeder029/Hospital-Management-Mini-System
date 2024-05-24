namespace HospitalManagementSystem
{
    partial class Diagnostic
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
            TBDiagMedicine = new TextBox();
            TBDiagSymptoms = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            ListBoxDiagnostics = new ListBox();
            label4 = new Label();
            label5 = new Label();
            BTNDiagReset = new Label();
            BTNDiagUpdate = new Label();
            BTNDiagAdd = new Label();
            BTNDiagDelete = new Label();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.Controls.Add(TBDiagMedicine);
            panel4.Controls.Add(TBDiagSymptoms);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(ListBoxDiagnostics);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(BTNDiagReset);
            panel4.Controls.Add(BTNDiagUpdate);
            panel4.Controls.Add(BTNDiagAdd);
            panel4.Controls.Add(BTNDiagDelete);
            panel4.Location = new Point(194, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1080, 681);
            panel4.TabIndex = 7;
            // 
            // TBDiagMedicine
            // 
            TBDiagMedicine.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBDiagMedicine.Location = new Point(425, 458);
            TBDiagMedicine.Name = "TBDiagMedicine";
            TBDiagMedicine.Size = new Size(363, 27);
            TBDiagMedicine.TabIndex = 50;
            // 
            // TBDiagSymptoms
            // 
            TBDiagSymptoms.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TBDiagSymptoms.Location = new Point(425, 414);
            TBDiagSymptoms.Name = "TBDiagSymptoms";
            TBDiagSymptoms.Size = new Size(363, 27);
            TBDiagSymptoms.TabIndex = 49;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(838, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 3);
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
            label1.Location = new Point(828, 11);
            label1.Name = "label1";
            label1.Size = new Size(240, 41);
            label1.TabIndex = 2;
            label1.Text = "DIAGNOSTICS";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ListBoxDiagnostics
            // 
            ListBoxDiagnostics.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxDiagnostics.FormattingEnabled = true;
            ListBoxDiagnostics.ItemHeight = 22;
            ListBoxDiagnostics.Location = new Point(17, 70);
            ListBoxDiagnostics.Name = "ListBoxDiagnostics";
            ListBoxDiagnostics.Size = new Size(1043, 268);
            ListBoxDiagnostics.TabIndex = 39;
            ListBoxDiagnostics.SelectedIndexChanged += ListBoxDiagnostics_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(321, 405);
            label4.Name = "label4";
            label4.Size = new Size(98, 44);
            label4.TabIndex = 41;
            label4.Text = "SYMPTOMS:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(321, 449);
            label5.Name = "label5";
            label5.Size = new Size(98, 44);
            label5.TabIndex = 42;
            label5.Text = "MEDICINE:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BTNDiagReset
            // 
            BTNDiagReset.BackColor = Color.MistyRose;
            BTNDiagReset.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNDiagReset.ForeColor = SystemColors.ActiveCaptionText;
            BTNDiagReset.Location = new Point(833, 567);
            BTNDiagReset.Name = "BTNDiagReset";
            BTNDiagReset.Size = new Size(145, 46);
            BTNDiagReset.TabIndex = 48;
            BTNDiagReset.Text = "RESET";
            BTNDiagReset.TextAlign = ContentAlignment.MiddleCenter;
            BTNDiagReset.Click += BTNDiagReset_Click;
            // 
            // BTNDiagUpdate
            // 
            BTNDiagUpdate.BackColor = Color.MistyRose;
            BTNDiagUpdate.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNDiagUpdate.ForeColor = SystemColors.ActiveCaptionText;
            BTNDiagUpdate.Location = new Point(606, 567);
            BTNDiagUpdate.Name = "BTNDiagUpdate";
            BTNDiagUpdate.Size = new Size(145, 46);
            BTNDiagUpdate.TabIndex = 47;
            BTNDiagUpdate.Text = "UPDATE";
            BTNDiagUpdate.TextAlign = ContentAlignment.MiddleCenter;
            BTNDiagUpdate.Click += BTNDiagUpdate_Click;
            // 
            // BTNDiagAdd
            // 
            BTNDiagAdd.BackColor = Color.MistyRose;
            BTNDiagAdd.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNDiagAdd.ForeColor = SystemColors.ActiveCaptionText;
            BTNDiagAdd.Location = new Point(98, 567);
            BTNDiagAdd.Name = "BTNDiagAdd";
            BTNDiagAdd.Size = new Size(145, 46);
            BTNDiagAdd.TabIndex = 45;
            BTNDiagAdd.Text = "ADD";
            BTNDiagAdd.TextAlign = ContentAlignment.MiddleCenter;
            BTNDiagAdd.Click += BTNDiagAdd_Click;
            // 
            // BTNDiagDelete
            // 
            BTNDiagDelete.BackColor = Color.MistyRose;
            BTNDiagDelete.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTNDiagDelete.ForeColor = SystemColors.ActiveCaptionText;
            BTNDiagDelete.Location = new Point(321, 567);
            BTNDiagDelete.Name = "BTNDiagDelete";
            BTNDiagDelete.Size = new Size(145, 46);
            BTNDiagDelete.TabIndex = 46;
            BTNDiagDelete.Text = "DELETE";
            BTNDiagDelete.TextAlign = ContentAlignment.MiddleCenter;
            BTNDiagDelete.Click += BTNDiagDelete_Click;
            // 
            // Diagnostic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1274, 679);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Diagnostic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diagnostic";
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
        private Label label8;
        private ListBox ListBoxDiagnostics;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label BTNDiagReset;
        private Label label7;
        private Label BTNDiagUpdate;
        private Label BTNDiagAdd;
        private Label BTNDiagDelete;
        private TextBox TBDiagMedicine;
        private TextBox TBDiagSymptoms;
    }
}