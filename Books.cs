using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace Book_Control
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            populate();
            //  DeleteBtn.Click += new EventHandler(DeleteBtn_Click_1);
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ahabd\source\repos\Book Control\Book Control\Database1.mdf;Integrated Security = True");
        private void populate()
        {
            con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BooksDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Filter()
        {
            con.Open();
            string query = "select * from BookTbl where BCat='" + CatCbSearchCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BooksDGV.DataSource = ds.Tables[0];
            con.Close();
            populate();
            Reset();

        }
        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BtitleTb.Text == "" || BautTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into BookTbl values('" + BtitleTb.Text + "','" + BautTb.Text + "','" + BCatCb.SelectedItem.ToString() + "'," + QtyTb.Text + "," + PriceTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Saved Successfully ");
                    con.Close();
                }
                catch (Exception Ex)

                {
                    MessageBox.Show(Ex.Message);

                }

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CatCbSearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            populate();
            CatCbSearchCb.SelectedIndex = -1;
        }

        private void Reset()
        {
            BtitleTb.Text = "";
            BautTb.Text = "";
            BCatCb.SelectedIndex = -1;
            PriceTb.Text = "";
            QtyTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();

        }
        int key = 0;
        private void BooksDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = BooksDGV.Rows[e.RowIndex];
                BtitleTb.Text = row.Cells[1].Value.ToString();
                BautTb.Text = row.Cells[2].Value.ToString();
                BCatCb.SelectedItem = row.Cells[3].Value.ToString();
                QtyTb.Text = row.Cells[4].Value.ToString();
                PriceTb.Text = row.Cells[5].Value.ToString();

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

        private void DeleteBtn_Click1(object sender, EventArgs e)
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
                    string query = "DELETE FROM BookTbl WHERE BId = @Key";
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
            if (BtitleTb.Text == "" || BautTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("No row or cell selected.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update BookTbl set BTitle = '" + BtitleTb.Text + "',BAuthor ='" + BautTb.Text + "',BCat='" + BCatCb.SelectedItem.ToString() + "',BCity=" + QtyTb.Text + ",BPrice=" + PriceTb.Text + "where BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated Successfully");
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

        private void label6_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DashBoard obj = new DashBoard();
            obj.Show();
            this.Hide();
        }
    }
}
