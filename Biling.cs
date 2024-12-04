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
    public partial class Biling : Form
    {
        public Biling()
        {
            InitializeComponent();
            populate();
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
            BookDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            try
            {
                con.Open();
                string query = "update BookTbl set BCity=" + newQty + "where BId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Key", key);
                cmd.ExecuteNonQuery();
                //      MessageBox.Show("Book Updated Successfully");
                con.Close();
                populate();
                //Reset();                            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int n = 0, Grdtotal = 0;
        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (QtyTb.Text == "" || Convert.ToInt32(QtyTb.Text) > stock)
            {
                MessageBox.Show("No Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = BtitleTb.Text;
                newRow.Cells[2].Value = QtyTb.Text;
                newRow.Cells[3].Value = PriceTb.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                UpdateBook();
                Grdtotal = Grdtotal + total;
                TotalLbl.Text = "Rs" + Grdtotal;


            }
        }


        int key = 0; int stock = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = BookDGV.Rows[e.RowIndex];
                BtitleTb.Text = row.Cells[1].Value.ToString();
                //BautTb.Text = row.Cells[2].Value.ToString();
                //BCatCb.SelectedItem = row.Cells[3].Value.ToString();
                // QtyTb.Text = row.Cells[4].Value.ToString();
                PriceTb.Text = row.Cells[5].Value.ToString();

                if (int.TryParse(row.Cells[0].Value.ToString(), out int selectedKey))
                {
                    key = selectedKey;
                    stock = selectedKey;
                }
                else
                {
                    key = Convert.ToInt32(row.Cells[0].Value.ToString());
                    stock = Convert.ToInt32(row.Cells[4].Value.ToString());
                }
            }

        }

        private void BookDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Reset()
        {
            BtitleTb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";
            ClientNameTb.Text = "";

        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }



        private void SaveBtn_Click(object sender, EventArgs e)
        {


            if (ClientNameTb.Text == "" || BtitleTb.Text == "")
            {
                MessageBox.Show("Select Client Name");

            }
            else
            {

                try
                {
                    con.Open();
                    string query = "insert into BillTbl values('" + UserNameLbl.Text + "','" + ClientNameTb.Text + "'," + Grdtotal + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved Successfully ");
                    con.Close();

                }
                catch (Exception Ex)

                {
                    MessageBox.Show(Ex.Message);

                }

                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }


            }
        }

        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {

                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos = pos + 20;

            }

            e.Graphics.DrawString("Grand Total : RS" + Grdtotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(60, pos + 50));
            e.Graphics.DrawString("__________ Books Store ____________", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(40, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            Grdtotal = 0;

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void Biling_Load(object sender, EventArgs e)
        {
            UserNameLbl.Text = Login.UserName;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
