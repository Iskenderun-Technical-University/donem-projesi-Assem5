namespace Book_Control
{
    partial class Biling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biling));
            label12 = new Label();
            BillDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ResetBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            label10 = new Label();
            label11 = new Label();
            PriceTb = new TextBox();
            QtyTb = new TextBox();
            label4 = new Label();
            ClientNameTb = new Label();
            label2 = new Label();
            SaveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            BautTb = new TextBox();
            BtitleTb = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            BookDGV = new DataGridView();
            TotalLbl = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            UserNameLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Liberation Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(218, 247);
            label12.Name = "label12";
            label12.Size = new Size(109, 21);
            label12.TabIndex = 49;
            label12.Text = "Books Lists";
            // 
            // BillDGV
            // 
            BillDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BillDGV.BackgroundColor = SystemColors.Control;
            BillDGV.BorderStyle = BorderStyle.None;
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            BillDGV.Enabled = false;
            BillDGV.Location = new Point(388, 53);
            BillDGV.Name = "BillDGV";
            BillDGV.RowTemplate.Height = 25;
            BillDGV.Size = new Size(528, 231);
            BillDGV.TabIndex = 48;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Books";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.Name = "Column5";
            // 
            // ResetBtn
            // 
            ResetBtn.ActiveBorderThickness = 1;
            ResetBtn.ActiveCornerRadius = 1;
            ResetBtn.ActiveFillColor = Color.FromArgb(64, 64, 64);
            ResetBtn.ActiveForecolor = Color.White;
            ResetBtn.ActiveLineColor = Color.FromArgb(64, 64, 64);
            ResetBtn.BackColor = SystemColors.Control;
            ResetBtn.BackgroundImage = (Image)resources.GetObject("ResetBtn.BackgroundImage");
            ResetBtn.ButtonText = "Reset";
            ResetBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ResetBtn.ForeColor = Color.SeaGreen;
            ResetBtn.IdleBorderThickness = 1;
            ResetBtn.IdleCornerRadius = 20;
            ResetBtn.IdleFillColor = Color.White;
            ResetBtn.IdleForecolor = Color.FromArgb(64, 64, 64);
            ResetBtn.IdleLineColor = Color.FromArgb(64, 64, 64);
            ResetBtn.Location = new Point(280, 182);
            ResetBtn.Margin = new Padding(5);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(102, 37);
            ResetBtn.TabIndex = 47;
            ResetBtn.TextAlign = ContentAlignment.MiddleCenter;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.ActiveBorderThickness = 1;
            EditBtn.ActiveCornerRadius = 1;
            EditBtn.ActiveFillColor = Color.FromArgb(64, 64, 64);
            EditBtn.ActiveForecolor = Color.White;
            EditBtn.ActiveLineColor = Color.FromArgb(64, 64, 64);
            EditBtn.BackColor = SystemColors.Control;
            EditBtn.BackgroundImage = (Image)resources.GetObject("EditBtn.BackgroundImage");
            EditBtn.ButtonText = "Add to Bill";
            EditBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.SeaGreen;
            EditBtn.IdleBorderThickness = 1;
            EditBtn.IdleCornerRadius = 20;
            EditBtn.IdleFillColor = Color.White;
            EditBtn.IdleForecolor = Color.FromArgb(64, 64, 64);
            EditBtn.IdleLineColor = Color.FromArgb(64, 64, 64);
            EditBtn.Location = new Point(159, 182);
            EditBtn.Margin = new Padding(5);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(102, 37);
            EditBtn.TabIndex = 45;
            EditBtn.TextAlign = ContentAlignment.MiddleCenter;
            EditBtn.Click += EditBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(283, 129);
            label10.Name = "label10";
            label10.Size = new Size(44, 21);
            label10.TabIndex = 44;
            label10.Text = "Price";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(280, 79);
            label11.Name = "label11";
            label11.Size = new Size(70, 21);
            label11.TabIndex = 43;
            label11.Text = "Quantity";
            // 
            // PriceTb
            // 
            PriceTb.Enabled = false;
            PriceTb.Location = new Point(280, 151);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(102, 23);
            PriceTb.TabIndex = 42;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(280, 101);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(102, 23);
            QtyTb.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(891, 0);
            label4.Name = "label4";
            label4.Size = new Size(25, 30);
            label4.TabIndex = 38;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // ClientNameTb
            // 
            ClientNameTb.AutoSize = true;
            ClientNameTb.BackColor = Color.Transparent;
            ClientNameTb.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            ClientNameTb.ForeColor = Color.FromArgb(64, 64, 64);
            ClientNameTb.Location = new Point(152, 129);
            ClientNameTb.Name = "ClientNameTb";
            ClientNameTb.Size = new Size(105, 23);
            ClientNameTb.TabIndex = 37;
            ClientNameTb.Text = "Client Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(152, 79);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 36;
            label2.Text = "Book Name";
            // 
            // SaveBtn
            // 
            SaveBtn.ActiveBorderThickness = 1;
            SaveBtn.ActiveCornerRadius = 1;
            SaveBtn.ActiveFillColor = Color.FromArgb(64, 64, 64);
            SaveBtn.ActiveForecolor = Color.White;
            SaveBtn.ActiveLineColor = Color.FromArgb(64, 64, 64);
            SaveBtn.BackColor = SystemColors.Control;
            SaveBtn.BackgroundImage = (Image)resources.GetObject("SaveBtn.BackgroundImage");
            SaveBtn.ButtonText = "Print";
            SaveBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.SeaGreen;
            SaveBtn.IdleBorderThickness = 1;
            SaveBtn.IdleCornerRadius = 20;
            SaveBtn.IdleFillColor = Color.White;
            SaveBtn.IdleForecolor = Color.FromArgb(64, 64, 64);
            SaveBtn.IdleLineColor = Color.FromArgb(64, 64, 64);
            SaveBtn.Location = new Point(696, 337);
            SaveBtn.Margin = new Padding(5);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(102, 37);
            SaveBtn.TabIndex = 35;
            SaveBtn.TextAlign = ContentAlignment.MiddleCenter;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // BautTb
            // 
            BautTb.Location = new Point(152, 152);
            BautTb.Name = "BautTb";
            BautTb.Size = new Size(122, 23);
            BautTb.TabIndex = 34;
            // 
            // BtitleTb
            // 
            BtitleTb.Enabled = false;
            BtitleTb.Location = new Point(152, 101);
            BtitleTb.Name = "BtitleTb";
            BtitleTb.Size = new Size(122, 23);
            BtitleTb.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Liberation Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(403, 5);
            label1.Name = "label1";
            label1.Size = new Size(171, 23);
            label1.TabIndex = 32;
            label1.Text = "IT BOOK STORE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 538);
            panel1.TabIndex = 31;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(0, 504);
            panel5.Name = "panel5";
            panel5.Size = new Size(148, 33);
            panel5.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(40, 4);
            label8.Name = "label8";
            label8.Size = new Size(71, 25);
            label8.TabIndex = 18;
            label8.Text = "Logout";
            label8.Click += label8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(145, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 57;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Liberation Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(626, 29);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 58;
            label7.Text = "Books Bill";
            // 
            // BookDGV
            // 
            BookDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookDGV.BackgroundColor = SystemColors.Control;
            BookDGV.BorderStyle = BorderStyle.None;
            BookDGV.Location = new Point(148, 290);
            BookDGV.Name = "BookDGV";
            BookDGV.RowTemplate.Height = 25;
            BookDGV.ScrollBars = ScrollBars.None;
            BookDGV.Size = new Size(492, 248);
            BookDGV.TabIndex = 59;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.BackColor = Color.Transparent;
            TotalLbl.Font = new Font("Liberation Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLbl.ForeColor = Color.FromArgb(64, 64, 64);
            TotalLbl.Location = new Point(699, 311);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(50, 21);
            TotalLbl.TabIndex = 60;
            TotalLbl.Text = "Total";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.BackColor = Color.Transparent;
            UserNameLbl.Font = new Font("Liberation Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameLbl.ForeColor = Color.FromArgb(64, 64, 64);
            UserNameLbl.Location = new Point(212, 5);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(108, 23);
            UserNameLbl.TabIndex = 61;
            UserNameLbl.Text = "UserName";
            // 
            // Biling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 538);
            Controls.Add(UserNameLbl);
            Controls.Add(TotalLbl);
            Controls.Add(BookDGV);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(label12);
            Controls.Add(BillDGV);
            Controls.Add(ResetBtn);
            Controls.Add(EditBtn);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(PriceTb);
            Controls.Add(QtyTb);
            Controls.Add(label4);
            Controls.Add(ClientNameTb);
            Controls.Add(label2);
            Controls.Add(SaveBtn);
            Controls.Add(BautTb);
            Controls.Add(BtitleTb);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Biling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biling";
            Load += Biling_Load;
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private DataGridView BillDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Label label10;
        private Label label11;
        private TextBox PriceTb;
        private TextBox QtyTb;
        // private ComboBox BCatCb;
        private Label label9;
        private Label label4;
        private Label ClientNameTb;
        private Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBtn;
        private TextBox BautTb;
        private TextBox BtitleTb;
        private Label label1;
        private Panel panel1;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label8;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private Label label7;
        private DataGridView BookDGV;
        private Label TotalLbl;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label UserNameLbl;
    }
}