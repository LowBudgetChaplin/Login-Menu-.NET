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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hello.Text= "Hello Serban";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hello.Text = "The text has been cancelled";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hello.Text = "Hello";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
