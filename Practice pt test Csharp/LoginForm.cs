using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_pt_test_Csharp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {

        }

        private void Login()
        {
            this.Hide();

            string id = txtUserid.Text;
            string pass = txtPassword.Text;


            if (id == "Serban" && pass == "12345")
            {
                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("Password or Email is incorrect!");
            }
        }

        private void ResetMyForm()
        {
            txtUserid.Text = "";
            txtPassword.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ResetMyForm();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) {
                Login();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                ResetMyForm();
            }
        }
    }
}
