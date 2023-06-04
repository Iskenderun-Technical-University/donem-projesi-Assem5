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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();
            UserDGV.CellContentClick += new DataGridViewCellEventHandler(UserDGV_CellContentClick);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ahabd\source\repos\Book Control\Book Control\Database1.mdf;Integrated Security = True");

        private void populate()
        {
            con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into UserTbl values('" + UnameTb.Text + "','" + PhoneTb.Text + "','" + AddTb.Text + "','" + PassTb.Text + "')";
                    // "insert into BookTbl values('" + BtitleTb.Text + "','" + BautTb.Text + "','" + BCatCb.SelectedItem.ToString() + "'," + QtyTb.Text + "," + PriceTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved Successfully ");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)

                {
                    MessageBox.Show(Ex.Message);

                }

            }
        }

        private void Users_Load(object sender, EventArgs e)
        {


        }

        private void Reset()
        {
            UnameTb.Text = "";
            PassTb.Text = "";
            PhoneTb.Text = "";
            AddTb.Text = "";

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();

        }


        int key = 0;
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = UserDGV.Rows[e.RowIndex];
                UnameTb.Text = row.Cells[1].Value.ToString();
                PhoneTb.Text = row.Cells[2].Value.ToString();
                AddTb.Text = row.Cells[3].Value.ToString();
                PassTb.Text = row.Cells[4].Value.ToString();

                if (int.TryParse(row.Cells[0].Value.ToString(), out int selectedKey))
                {
                    key = selectedKey;
                }
                else
                {
                    key = 0;
                }
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("No row or cell selected.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM UserTbl WHERE UId = @Key";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Deleted Successfully");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("No row or cell selected.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update UserTbl set UName = '" + UnameTb.Text + "',UPhone='" + PhoneTb.Text + "',UAdd='" + AddTb.Text + "',UPass='" + PassTb.Text + "' where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("UserTbl Updated Successfully");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DashBoard obj = new DashBoard();
            obj.Show();
            this.Hide();
        }
    }
}
