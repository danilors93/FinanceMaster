namespace BankManage
{
    partial class withdrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(withdrawForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BalanceLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.WdAmtDt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.WdAcNumDt = new System.Windows.Forms.TextBox();
            this.WdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BackBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.guna2Panel1.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BalanceLbl);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.WdAmtDt);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.WdAcNumDt);
            this.panel2.Controls.Add(this.WdBtn);
            this.panel2.Location = new System.Drawing.Point(95, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 323);
            this.panel2.TabIndex = 52;
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
            this.label4.TabIndex = 52;
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
            this.BalanceLbl.TabIndex = 51;
            this.BalanceLbl.Text = "Current Balance";
            this.BalanceLbl.Click += new System.EventHandler(this.BalanceLbl_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label12.Location = new System.Drawing.Point(111, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 23);
            this.label12.TabIndex = 50;
            this.label12.Text = "Amount";
            // 
            // WdAmtDt
            // 
            this.WdAmtDt.Location = new System.Drawing.Point(62, 129);
            this.WdAmtDt.Name = "WdAmtDt";
            this.WdAmtDt.Size = new System.Drawing.Size(192, 26);
            this.WdAmtDt.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label11.Location = new System.Drawing.Point(72, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 23);
            this.label11.TabIndex = 48;
            this.label11.Text = "Account Number";
            // 
            // WdAcNumDt
            // 
            this.WdAcNumDt.Location = new System.Drawing.Point(62, 70);
            this.WdAcNumDt.Name = "WdAcNumDt";
            this.WdAcNumDt.Size = new System.Drawing.Size(192, 26);
            this.WdAcNumDt.TabIndex = 33;
            this.WdAcNumDt.TextChanged += new System.EventHandler(this.WdAcNumDt_TextChanged);
            // 
            // WdBtn
            // 
            this.WdBtn.AutoRoundedCorners = true;
            this.WdBtn.BorderColor = System.Drawing.Color.DarkMagenta;
            this.WdBtn.BorderRadius = 16;
            this.WdBtn.BorderThickness = 1;
            this.WdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WdBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WdBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WdBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WdBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WdBtn.FillColor = System.Drawing.Color.Transparent;
            this.WdBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WdBtn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.WdBtn.Location = new System.Drawing.Point(84, 181);
            this.WdBtn.Name = "WdBtn";
            this.WdBtn.Size = new System.Drawing.Size(148, 35);
            this.WdBtn.TabIndex = 47;
            this.WdBtn.Text = "Withdraw";
            this.WdBtn.Click += new System.EventHandler(this.WdBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(190, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 34;
            this.label2.Text = "Withdraw";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.ImageRotate = 0F;
            this.BackBtn.Location = new System.Drawing.Point(361, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(40, 40);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackBtn.TabIndex = 58;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(407, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 57;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // withdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 456);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "withdrawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "withdrawForm";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox WdAmtDt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WdAcNumDt;
        private Guna.UI2.WinForms.Guna2Button WdBtn;
        private Guna.UI2.WinForms.Guna2PictureBox BackBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label BalanceLbl;
        private System.Windows.Forms.Label label4;
    }
}