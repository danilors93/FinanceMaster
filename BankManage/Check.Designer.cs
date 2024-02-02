namespace BankManage
{
    partial class Check
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBalTb = new System.Windows.Forms.TextBox();
            this.BalanceLbl = new System.Windows.Forms.Label();
            this.CheckBalBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BackBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CheckBalTb);
            this.panel1.Controls.Add(this.BalanceLbl);
            this.panel1.Controls.Add(this.CheckBalBtn);
            this.panel1.Location = new System.Drawing.Point(95, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 323);
            this.panel1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(71, 43);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(128, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Clear";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CheckBalTb
            // 
            this.CheckBalTb.Location = new System.Drawing.Point(30, 69);
            this.CheckBalTb.Name = "CheckBalTb";
            this.CheckBalTb.Size = new System.Drawing.Size(255, 26);
            this.CheckBalTb.TabIndex = 33;
            this.CheckBalTb.TextChanged += new System.EventHandler(this.CheckBalTb_TextChanged);
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.AutoSize = true;
            this.BalanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.BalanceLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLbl.ForeColor = System.Drawing.Color.DarkMagenta;
            this.BalanceLbl.Location = new System.Drawing.Point(72, 105);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BalanceLbl.Size = new System.Drawing.Size(170, 23);
            this.BalanceLbl.TabIndex = 36;
            this.BalanceLbl.Text = "Current Balance";
            this.BalanceLbl.Click += new System.EventHandler(this.BalanceLbl_Click);
            // 
            // CheckBalBtn
            // 
            this.CheckBalBtn.AutoRoundedCorners = true;
            this.CheckBalBtn.BorderColor = System.Drawing.Color.DarkMagenta;
            this.CheckBalBtn.BorderRadius = 16;
            this.CheckBalBtn.BorderThickness = 1;
            this.CheckBalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBalBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckBalBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheckBalBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheckBalBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheckBalBtn.FillColor = System.Drawing.Color.Transparent;
            this.CheckBalBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.CheckBalBtn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.CheckBalBtn.Location = new System.Drawing.Point(88, 177);
            this.CheckBalBtn.Name = "CheckBalBtn";
            this.CheckBalBtn.Size = new System.Drawing.Size(139, 35);
            this.CheckBalBtn.TabIndex = 47;
            this.CheckBalBtn.Text = "Check";
            this.CheckBalBtn.Click += new System.EventHandler(this.CheckBalBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(128, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Check Your Balance";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(406, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 52;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.ImageRotate = 0F;
            this.BackBtn.Location = new System.Drawing.Point(360, -1);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(40, 40);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackBtn.TabIndex = 56;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox4);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.DarkMagenta;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(58, 456);
            this.guna2Panel1.TabIndex = 57;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(3, 21);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 18;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 456);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check";
            this.Load += new System.EventHandler(this.Check_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CheckBalTb;
        private Guna.UI2.WinForms.Guna2Button CheckBalBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BalanceLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox BackBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
    }
}