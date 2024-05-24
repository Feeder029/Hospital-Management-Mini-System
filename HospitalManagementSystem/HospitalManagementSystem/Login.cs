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
    public partial class Login : Form
    {
        string user, pass;
        public Login()
        {
            InitializeComponent();
            AddMouseEvents(BTNLogin, true);
            AddMouseEvents(BTNQuit, true);
        }

        private void TBUser_TextChanged(object sender, EventArgs e)
        {
            user = TBUser.Text;
        }

        private void TBPass_TextChanged(object sender, EventArgs e)
        {
            pass = TBPass.Text;
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("There is an empty field", "Error");
            }
            else
            {
                if (user == "Admin" && pass == "Admin")
                {
                    new MainForm().Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or pass", "Error");
                }
            }
        }

        private void BTNQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to quit?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void CBShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (CBShowpass.Checked)
            {
                TBPass.UseSystemPasswordChar = false;
            }
            else
            {
                TBPass.UseSystemPasswordChar = true;
            }
        }

        private void AddMouseEvents(Label label, bool isLogin = false, bool isQuit = false)
        {
            if (isLogin)
            {
                label.MouseEnter += (sender, e) => label.ForeColor = Color.Black;
                label.MouseLeave += (sender, e) => label.ForeColor = Color.Lime;
            }
            else if (isQuit)
            {
                label.MouseEnter += (sender, e) => label.ForeColor = Color.Black;
                label.MouseLeave += (sender, e) => label.ForeColor = Color.Red;
            }

        }
    }
}
