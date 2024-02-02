namespace BankManage
{
    partial class Agents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agents));
            this.SubmitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AgentsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.APhoneTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.APasswordTb = new System.Windows.Forms.TextBox();
            this.ANameTb = new System.Windows.Forms.TextBox();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AAddressTb = new System.Windows.Forms.TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SettingsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.AutoRoundedCorners = true;
            this.SubmitBtn.BorderColor = System.Drawing.Color.DarkMagenta;
            this.SubmitBtn.BorderRadius = 24;
            this.SubmitBtn.BorderThickness = 1;
            this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitBtn.FillColor = System.Drawing.Color.Transparent;
            this.SubmitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.SubmitBtn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.SubmitBtn.Location = new System.Drawing.Point(305, 310);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(197, 51);
            this.SubmitBtn.TabIndex = 52;
            this.SubmitBtn.Text = "Add";
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // AgentsDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(188)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.AgentsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AgentsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AgentsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AgentsDGV.ColumnHeadersHeight = 25;
            this.AgentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(212)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(111)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AgentsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.AgentsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(212)))), ((int)(((byte)(239)))));
            this.AgentsDGV.Location = new System.Drawing.Point(62, 429);
            this.AgentsDGV.Name = "AgentsDGV";
            this.AgentsDGV.RowHeadersVisible = false;
            this.AgentsDGV.RowHeadersWidth = 62;
            this.AgentsDGV.RowTemplate.Height = 28;
            this.AgentsDGV.Size = new System.Drawing.Size(1225, 298);
            this.AgentsDGV.TabIndex = 51;
            this.AgentsDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple;
            this.AgentsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.AgentsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AgentsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AgentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(188)))), ((int)(((byte)(231)))));
            this.AgentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.AgentsDGV.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.AgentsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(212)))), ((int)(((byte)(239)))));
            this.AgentsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.AgentsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AgentsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AgentsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AgentsDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.AgentsDGV.ThemeStyle.ReadOnly = false;
            this.AgentsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(212)))), ((int)(((byte)(239)))));
            this.AgentsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AgentsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AgentsDGV.ThemeStyle.RowsStyle.Height = 28;
            this.AgentsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(111)))), ((int)(((byte)(202)))));
            this.AgentsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.AgentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgentsDVG_CellContentClick);
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoRoundedCorners = true;
            this.CancelBtn.BorderColor = System.Drawing.Color.DarkMagenta;
            this.CancelBtn.BorderRadius = 24;
            this.CancelBtn.BorderThickness = 1;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.FillColor = System.Drawing.Color.Transparent;
            this.CancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.CancelBtn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.CancelBtn.Location = new System.Drawing.Point(843, 310);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(197, 51);
            this.CancelBtn.TabIndex = 50;
            this.CancelBtn.Text = "Delete";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.AutoRoundedCorners = true;
            this.EditBtn.BorderColor = System.Drawing.Color.DarkMagenta;
            this.EditBtn.BorderRadius = 24;
            this.EditBtn.BorderThickness = 1;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtn.FillColor = System.Drawing.Color.Transparent;
            this.EditBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.EditBtn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.EditBtn.Location = new System.Drawing.Point(572, 310);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(197, 51);
            this.EditBtn.TabIndex = 49;
            this.EditBtn.Text = "Edit";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(946, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 46;
            this.label8.Text = "Phone";
            // 
            // APhoneTb
            // 
            this.APhoneTb.Location = new System.Drawing.Point(951, 160);
            this.APhoneTb.Name = "APhoneTb";
            this.APhoneTb.Size = new System.Drawing.Size(255, 26);
            this.APhoneTb.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(678, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 40;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(406, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 38;
            this.label4.Text = "Password";
            // 
            // APasswordTb
            // 
            this.APasswordTb.Location = new System.Drawing.Point(411, 160);
            this.APasswordTb.Name = "APasswordTb";
            this.APasswordTb.PasswordChar = '*';
            this.APasswordTb.Size = new System.Drawing.Size(255, 26);
            this.APasswordTb.TabIndex = 37;
            // 
            // ANameTb
            // 
            this.ANameTb.Location = new System.Drawing.Point(141, 160);
            this.ANameTb.Name = "ANameTb";
            this.ANameTb.Size = new System.Drawing.Size(255, 26);
            this.ANameTb.TabIndex = 35;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.ImageRotate = 0F;
            this.CloseBtn.Location = new System.Drawing.Point(1241, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(45, 45);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 34;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(574, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "View Accounts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(527, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 41);
            this.label1.TabIndex = 32;
            this.label1.Text = "Manage Agents";
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
            // AAddressTb
            // 
            this.AAddressTb.Location = new System.Drawing.Point(683, 160);
            this.AAddressTb.Multiline = true;
            this.AAddressTb.Name = "AAddressTb";
            this.AAddressTb.Size = new System.Drawing.Size(253, 118);
            this.AAddressTb.TabIndex = 39;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox4);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.DarkMagenta;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(58, 727);
            this.guna2Panel1.TabIndex = 31;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(64, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(55, 55);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 53;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(136, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name";
            // 
            // SettingsLbl
            // 
            this.SettingsLbl.AutoSize = true;
            this.SettingsLbl.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLbl.ForeColor = System.Drawing.Color.DarkMagenta;
            this.SettingsLbl.Location = new System.Drawing.Point(125, 21);
            this.SettingsLbl.Name = "SettingsLbl";
            this.SettingsLbl.Size = new System.Drawing.Size(82, 21);
            this.SettingsLbl.TabIndex = 54;
            this.SettingsLbl.Text = "Settings";
            this.SettingsLbl.Click += new System.EventHandler(this.SettingsLbl_Click);
            // 
            // Agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 727);
            this.Controls.Add(this.SettingsLbl);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.AgentsDGV);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.APhoneTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.APasswordTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ANameTb);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AAddressTb);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agents";
            ((System.ComponentModel.ISupportInitialize)(this.AgentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button SubmitBtn;
        private Guna.UI2.WinForms.Guna2DataGridView AgentsDGV;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox APhoneTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox APasswordTb;
        private System.Windows.Forms.TextBox ANameTb;
        private Guna.UI2.WinForms.Guna2PictureBox CloseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.TextBox AAddressTb;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SettingsLbl;
    }
}