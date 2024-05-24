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
    public partial class Patient : Form
    {
        int patID, patAge;
        string patLastN, patFirstN, patGender, patDisease;

        public Patient()
        {
            InitializeComponent();
            AddMouseEvents(BTNPatAdd);
            AddMouseEvents(BTNPatDelete);
            AddMouseEvents(BTNPatReset);
            AddMouseEvents(BTNPatUpdate);
            CBPatGender.SelectedIndex = 0;
        }

        private void TBPatDisease_TextChanged(object sender, EventArgs e)
        {

        }

        #region buttons
        //add
        private void BTNPatAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBPatID.Text) || string.IsNullOrEmpty(TBPatFirstN.Text) || string.IsNullOrEmpty(TBPatLastN.Text) || string.IsNullOrEmpty(TBPatAge.Text) || string.IsNullOrEmpty(TBPatDisease.Text) || CBPatGender.SelectedIndex == 0)
            {
                MessageBox.Show("Add some information!", "Failed");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to add this information?", "Adding Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    patID = Convert.ToInt32(TBPatID.Text);
                    patLastN = TBPatLastN.Text;
                    patFirstN = TBPatFirstN.Text;
                    patGender = CBPatGender.Text;
                    patDisease = TBPatDisease.Text;
                    patAge = Convert.ToInt32(TBPatAge.Text);

                    MessageBox.Show("Information successfully added!", "Successful");
                    ListBoxPatients.Items.Add(patID + (" | ") + patLastN + (" | ") + patFirstN + (" | ") + patAge + (" | ") + patGender + (" | ") + patDisease);

                    TBPatID.Clear();
                    TBPatFirstN.Clear();
                    TBPatLastN.Clear();
                    CBPatGender.SelectedIndex = 0;
                    TBPatDisease.Clear();
                    TBPatAge.Clear();

                    DataTable table = new DataTable();

                }
                else
                {
                    MessageBox.Show("Information unsuccessfully added!", "Failed");
                }

            }
        }

        //delete
        private void BTNPatDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this row?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (ListBoxPatients.SelectedIndex != -1)
                {

                    ListBoxPatients.Items.RemoveAt(ListBoxPatients.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete", "Failed");
            }
        }


        //update
        private void BTNPatUpdate_Click(object sender, EventArgs e)
        {
            if (ListBoxPatients.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(TBPatID.Text) || string.IsNullOrEmpty(TBPatFirstN.Text) || string.IsNullOrEmpty(TBPatLastN.Text) || string.IsNullOrEmpty(TBPatAge.Text) || CBPatGender.SelectedIndex == 0 || string.IsNullOrEmpty(TBPatDisease.Text))
                {
                    MessageBox.Show("Add some information!", "Failed");
                }
                else
                {
                    patID = Convert.ToInt32(TBPatID.Text);
                    patFirstN = TBPatFirstN.Text;
                    patLastN = TBPatLastN.Text;
                    patGender = CBPatGender.Text;
                    patDisease = TBPatDisease.Text;
                    patAge = Convert.ToInt32(TBPatAge.Text);

                    DialogResult result = MessageBox.Show("Are you sure to update this row?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        string updatedItem = patID + (" | ") + patLastN + (" | ") + patFirstN + (" | ") + patAge + (" | ") + patGender + (" | ") + patDisease;
                        ListBoxPatients.Items[ListBoxPatients.SelectedIndex] = updatedItem;

                        MessageBox.Show("Information successfully updated!", "Successful");

                        TBPatID.Clear();
                        TBPatFirstN.Clear();
                        TBPatLastN.Clear();
                        CBPatGender.SelectedIndex = 0;
                        TBPatDisease.Clear();
                        TBPatAge.Clear();

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
        private void BTNPatReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to reset this table?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ListBoxPatients.Items.Clear();
            }
        }

        //when you click an index with data, it fills out the textbox with its data
        private void ListBoxPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxPatients.SelectedIndex != -1)
            {
                string selectedItem = ListBoxPatients.SelectedItem.ToString();
                string[] parts = selectedItem.Split('|').Select(p => p.Trim()).ToArray();

                if (parts.Length == 6)
                {
                    TBPatID.Text = parts[0];
                    TBPatLastN.Text = parts[1];
                    TBPatFirstN.Text = parts[2];
                    TBPatAge.Text = parts[3];
                    CBPatGender.SelectedItem = parts[4];
                    TBPatDisease.Text = parts[5];
                }
            }
        }
        #endregion

        //Hover
        private void AddMouseEvents(Label label, bool isLogout = false)
        {

            label.MouseEnter += (sender, e) => label.BackColor = Color.SlateGray;
            label.MouseLeave += (sender, e) => label.BackColor = Color.MistyRose;

        }

        private void TBPatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBPatFirstN_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBPatLastN_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
