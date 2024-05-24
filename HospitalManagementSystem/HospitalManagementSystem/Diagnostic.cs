using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Diagnostic : Form
    {
        string diagSymp, diagMeds;
        public Diagnostic()
        {
            InitializeComponent();
            AddMouseEvents(BTNDiagAdd);
            AddMouseEvents(BTNDiagDelete);
            AddMouseEvents(BTNDiagReset);
            AddMouseEvents(BTNDiagUpdate);
        }

        

        private void TBDiagSymptoms_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBDiagMedicine_TextChanged(object sender, EventArgs e)
        {

        }

        #region buttons
        //when you click an index with data, it fills out the textbox with its data
        private void ListBoxDiagnostics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxDiagnostics.SelectedIndex != -1)
            {
                string selectedItem = ListBoxDiagnostics.SelectedItem.ToString();
                string[] parts = selectedItem.Split('|').Select(p => p.Trim()).ToArray();

                if (parts.Length == 2)
                {
                    TBDiagSymptoms.Text = parts[0];
                    TBDiagMedicine.Text = parts[1];
                }
            }
        }

        //add
        private void BTNDiagAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBDiagMedicine.Text) || string.IsNullOrEmpty(TBDiagSymptoms.Text))
            {
                MessageBox.Show("Add some information!", "Failed");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to add this information?", "Adding Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    diagMeds = TBDiagMedicine.Text;
                    diagSymp = TBDiagSymptoms.Text;

                    MessageBox.Show("Information successfully added!", "Successful");
                    ListBoxDiagnostics.Items.Add(diagSymp + (" | ") + diagMeds);

                    TBDiagSymptoms.Clear();
                    TBDiagMedicine.Clear();


                    DataTable table = new DataTable();

                }
                else
                {
                    MessageBox.Show("Information unsuccessfully added!", "Failed");
                }

            }
        }


        //delete
        private void BTNDiagDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this row?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (ListBoxDiagnostics.SelectedIndex != -1)
                {

                    ListBoxDiagnostics.Items.RemoveAt(ListBoxDiagnostics.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete", "Failed");
            }
        }

        //update
        private void BTNDiagUpdate_Click(object sender, EventArgs e)
        {
            if (ListBoxDiagnostics.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(TBDiagMedicine.Text) || string.IsNullOrEmpty(TBDiagSymptoms.Text))
                {
                    MessageBox.Show("Add some information!", "Failed");
                }
                else
                {
                    diagMeds = TBDiagMedicine.Text;
                    diagSymp = TBDiagSymptoms.Text;

                    DialogResult result = MessageBox.Show("Are you sure to update this row?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        string updatedItem = diagSymp + (" | ") + diagMeds;
                        ListBoxDiagnostics.Items[ListBoxDiagnostics.SelectedIndex] = updatedItem;

                        MessageBox.Show("Information successfully updated!", "Successful");

                        TBDiagMedicine.Clear();
                        TBDiagSymptoms.Clear();


                    }
                    else
                    {
                        MessageBox.Show("Information unsuccessfully updated!", "Failed");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a row to update", "Failed");
            }
        }

        //reset
        private void BTNDiagReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to reset this table?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ListBoxDiagnostics.Items.Clear();
            }
        }
        #endregion

        //Hover
        private void AddMouseEvents(Label label, bool isLogout = false)
        {

            label.MouseEnter += (sender, e) => label.BackColor = Color.SlateGray;
            label.MouseLeave += (sender, e) => label.BackColor = Color.MistyRose;

        }
    }
}
