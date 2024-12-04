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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ahabd\source\repos\Book Control\Book Control\Database1.mdf;Integrated Security = True");

        private void DashBoard_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(BCity)from BookTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BookStockLbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(Amount)from BillTbl", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLbl.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select Count(*)from UserTbl", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UsersLbl.Text = dt2.Rows[0][0].ToString();
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DashBoard obj = new DashBoard();
            obj.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }
    }
}
