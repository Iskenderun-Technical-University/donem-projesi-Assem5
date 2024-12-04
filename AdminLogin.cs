using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Control
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {

            InitializeComponent();
            UPassTb.KeyPress += UPassTb_KeyPress;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (UPassTb.Text == "Password")
            {
                Books obj = new Books();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password. Contact The Admin");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
        private void UPassTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the "ding" sound
                bunifuThinButton21_Click(sender, e); // Simulate a click on the Accept button
            }
        }
    }
}
