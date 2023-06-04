namespace Book_Control
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            label4 = new Label();
            label3 = new Label();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            UPassTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(399, -1);
            label4.Name = "label4";
            label4.Size = new Size(25, 30);
            label4.TabIndex = 17;
            label4.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(188, 142);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // bunifuThinButton21
            // 
            bunifuThinButton21.ActiveBorderThickness = 1;
            bunifuThinButton21.ActiveCornerRadius = 1;
            bunifuThinButton21.ActiveFillColor = Color.FromArgb(64, 64, 64);
            bunifuThinButton21.ActiveForecolor = Color.White;
            bunifuThinButton21.ActiveLineColor = Color.FromArgb(64, 64, 64);
            bunifuThinButton21.BackColor = SystemColors.Control;
            bunifuThinButton21.BackgroundImage = (Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
            bunifuThinButton21.ButtonText = "Login";
            bunifuThinButton21.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuThinButton21.ForeColor = Color.SeaGreen;
            bunifuThinButton21.IdleBorderThickness = 1;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = Color.White;
            bunifuThinButton21.IdleForecolor = Color.FromArgb(64, 64, 64);
            bunifuThinButton21.IdleLineColor = Color.FromArgb(64, 64, 64);
            bunifuThinButton21.Location = new Point(198, 193);
            bunifuThinButton21.Margin = new Padding(5);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(131, 38);
            bunifuThinButton21.TabIndex = 14;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton21.Click += bunifuThinButton21_Click;
            // 
            // UPassTb
            // 
            UPassTb.Location = new Point(188, 170);
            UPassTb.Name = "UPassTb";
            UPassTb.PasswordChar = '*';
            UPassTb.Size = new Size(170, 23);
            UPassTb.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(219, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Liberation Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(219, 4);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 10;
            label1.Text = "Admin Login";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 324);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Liberation Sans", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(230, 227);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 18;
            label2.Text = "Cancel";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 322);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 322);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(bunifuThinButton21);
            Controls.Add(UPassTb);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            Load += AdminLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private TextBox UPassTb;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}