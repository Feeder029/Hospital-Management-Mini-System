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
    public partial class Doctors : Form
    {
        int docID, docLicense;
        string docLastN, docFirstN, docGender;


        public Doctors()
        {
            InitializeComponent();
            AddMouseEvents(BTNDocAdd);
            AddMouseEvents(BTNDocDelete);
            AddMouseEvents(BTNDocReset);
            AddMouseEvents(BTNDocUpdate);
            CBDocGender.SelectedIndex = 0;
        }

        private void TBDocID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        #region buttons
        //add
        private void BTNDocAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBDocID.Text) || string.IsNullOrEmpty(TBDocFirstN.Text) || string.IsNullOrEmpty(TBDocLastN.Text) || CBDocGender.SelectedIndex == 0 || string.IsNullOrEmpty(TBDocLicence.Text))
            {
                MessageBox.Show("Add some information!", "Failed");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to add this information?", "Adding Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    docID = Convert.ToInt32(TBDocID.Text);
                    docLicense = Convert.ToInt32(TBDocLicence.Text);
                    docFirstN = TBDocFirstN.Text;
                    docLastN = TBDocLastN.Text;
                    docGender = CBDocGender.Text;

                    MessageBox.Show("Information successfully added!", "Successful");
                    ListBoxDoctors.Items.Add(docID + (" | ") + docLastN + (" | ") + docFirstN + (" | ") + docGender + (" | ") + docLicense);

                    TBDocID.Clear();
                    TBDocFirstN.Clear();
                    TBDocLastN.Clear();
                    CBDocGender.SelectedIndex = 0;
                    TBDocLicence.Clear();

                    DataTable table = new DataTable();

                }
                else
                {
                    MessageBox.Show("Information unsuccessfully added!", "Failed");
                }

            }
        }

        //delete
        private void BTNDocDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this row?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (ListBoxDoctors.SelectedIndex != -1)
                {

                    ListBoxDoctors.Items.RemoveAt(ListBoxDoctors.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete", "Failed");
            }

        }

        //update
        private void BTNDocUpdate_Click(object sender, EventArgs e)
        {
            if (ListBoxDoctors.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(TBDocID.Text) || string.IsNullOrEmpty(TBDocFirstN.Text) || string.IsNullOrEmpty(TBDocLastN.Text) || string.IsNullOrEmpty(TBDocLicence.Text) || CBDocGender.SelectedIndex == 0)
                {
                    MessageBox.Show("Add some information!", "Failed");
                }
                else
                {
                    docID = Convert.ToInt32(TBDocID.Text);
                    docLicense = Convert.ToInt32(TBDocLicence.Text);
                    docFirstN = TBDocFirstN.Text;
                    docLastN = TBDocLastN.Text;
                    docGender = CBDocGender.Text;

                    DialogResult result = MessageBox.Show("Are you sure to update this row?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        string updatedItem = docID + (" | ") + docLastN + (" | ") + docFirstN + (" | ") + docGender + (" | ") + docLicense;
                        ListBoxDoctors.Items[ListBoxDoctors.SelectedIndex] = updatedItem;

                        MessageBox.Show("Information successfully updated!", "Successful");

                        TBDocID.Clear();
                        TBDocFirstN.Clear();
                        TBDocLastN.Clear();
                        CBDocGender.SelectedIndex = 0;
                        TBDocLicence.Clear();


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


        //when you click an index with data, it fills out the textbox with its data
        private void ListBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxDoctors.SelectedIndex != -1)
            {
                string selectedItem = ListBoxDoctors.SelectedItem.ToString();
                string[] parts = selectedItem.Split('|').Select(p => p.Trim()).ToArray();

                if (parts.Length == 5)
                {
                    TBDocID.Text = parts[0];
                    TBDocLastN.Text = parts[1];
                    TBDocFirstN.Text = parts[2];
                    CBDocGender.SelectedItem = parts[3];
                    TBDocLicence.Text = parts[4];
                }
            }
        }

        //reset
        private void BTNDocReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to reset this table?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ListBoxDoctors.Items.Clear();
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
