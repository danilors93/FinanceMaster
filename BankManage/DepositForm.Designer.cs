namespace BankManage
{
    partial class DepositForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BalanceLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DepositAmountTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DepositAccountTb = new System.Windows.Forms.TextBox();
            this.DepositBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BackBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.guna2Panel1.TabIndex = 3;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.BalanceLbl);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.DepositAmountTb);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.DepositAccountTb);
            this.panel3.Controls.Add(this.DepositBtn);
            this.panel3.Location = new System.Drawing.Point(95, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 323);
            this.panel3.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(128, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "Clear";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.AutoSize = true;
            this.BalanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.BalanceLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLbl.ForeColor = System.Drawing.Color.DarkMagenta;
            this.BalanceLbl.Location = new System.Drawing.Point(71, 239);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BalanceLbl.Size = new System.Drawing.Size(170, 23);
            this.BalanceLbl.TabIndex = 53;
            this.BalanceLbl.Text = "Current Balance";
            this.BalanceLbl.Click += new System.EventHandler(this.BalanceLbl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(111, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 50;
            this.label8.Text = "Amount";
            // 
            // DepositAmountTb
            // 
            this.DepositAmountTb.Location = new System.Drawing.Point(62, 129);
            this.DepositAmountTb.Name = "DepositAmountTb";
            this.DepositAmountTb.Size = new System.Drawing.Size(192, 26);
            this.DepositAmountTb.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label9.Location = new System.Drawing.Point(72, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "Account Number";
            // 
            // DepositAccountTb
            // 
            this.DepositAccountTb.Location = new System.Drawing.Point(62, 70);
            this.DepositAccountTb.Name = "DepositAccountTb";
            this.DepositAccountTb.Size = new System.Drawing.Size(192, 26);
            this.DepositAccountTb.TabIndex = 33;
            // 
            // DepositBtn
            // 
            this.DepositBtn.AutoRoundedCorners = true;
            this.DepositBtn.BorderColor = System.Drawing.Color.DarkMagenta;
            this.DepositBtn.BorderRadius = 16;
            this.DepositBtn.BorderThickness = 1;
            this.DepositBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepositBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DepositBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DepositBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DepositBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DepositBtn.FillColor = System.Drawing.Color.Transparent;
            this.DepositBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.DepositBtn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.DepositBtn.Location = new System.Drawing.Point(84, 181);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(148, 35);
            this.DepositBtn.TabIndex = 47;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label10.Location = new System.Drawing.Point(190, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 28);
            this.label10.TabIndex = 34;
            this.label10.Text = "Deposit";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.ImageRotate = 0F;
            this.BackBtn.Location = new System.Drawing.Point(364, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(40, 40);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackBtn.TabIndex = 60;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(410, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 59;
            this.guna2PictureBox1.TabStop = false;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 456);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepositForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositForm";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DepositAmountTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DepositAccountTb;
        private Guna.UI2.WinForms.Guna2Button DepositBtn;
        private Guna.UI2.WinForms.Guna2PictureBox BackBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BalanceLbl;
    }
}