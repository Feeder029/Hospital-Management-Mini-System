using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            openChildForm(new Home());
            AddMouseEvents(BTNLogout, true);
            AddMouseEvents(BTNHome);
            AddMouseEvents(BTNDoctor);
            AddMouseEvents(BTNPatient);
            AddMouseEvents(BTNDiagnostic);

        }

        public Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }


            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region SideButtons
        private void BTNHome_Click(object sender, EventArgs e)
        {
            openChildForm(new Home());

            SetActiveButtons(BTNHome);

        }

        private void BTNDoctor_Click(object sender, EventArgs e)
        {
            openChildForm(new Doctors());

            SetActiveButtons(BTNDoctor);
        }

        private void BTNPatient_Click(object sender, EventArgs e)
        {
            openChildForm(new Patient());

            SetActiveButtons(BTNPatient);
        }

        private void BTNDiagnostic_Click(object sender, EventArgs e)
        {
            openChildForm(new Diagnostic());

            SetActiveButtons(BTNDiagnostic);
        }

        private void BTNLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Warning", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        //Hover
        private void AddMouseEvents(Label label, bool isLogout = false)
        {
            if (isLogout)
            {
                label.MouseEnter += (sender, e) => label.ForeColor = Color.Black;
                label.MouseLeave += (sender, e) => label.ForeColor = Color.Red;
            }
            else
            {
                label.MouseEnter += (sender, e) => label.BackColor = Color.SlateGray;
                label.MouseLeave += (sender, e) => label.BackColor = Color.Snow;
            }
        }

        //ActivePanel
        private void SetActiveButtons(Label activeButton)
        {
            BTNActiveHome.Visible = activeButton == BTNHome;
            BTNActiveDoctor.Visible = activeButton == BTNDoctor;
            BTNActivePatient.Visible = activeButton == BTNPatient;
            BTNActiveDiagnostic.Visible = activeButton == BTNDiagnostic;
        }

        #endregion

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}