using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Control
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            UPassTb.KeyPress += UPassTb_KeyPress;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ahabd\source\repos\Book Control\Book Control\Database1.mdf;Integrated Security = True");

        public static string UserName = "";
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from UserTbl where UName = '" + UNameTb.Text + "' and UPass= '" + UPassTb.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //Books obj = new Books();
                UserName = UNameTb.Text;
                Books obj = new Books();
                obj.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AdminLogin obj = new AdminLogin();
            obj.Show();
            this.Hide();
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
