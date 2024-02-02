using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace BankManage
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (NewPassTb.Text == "" || ConfirmPassTb.Text == "")
            {
                MessageBox.Show("Confirm New Password");
            }
            else if (NewPassTb.Text != ConfirmPassTb.Text)
            {
                MessageBox.Show("Passwords do not match. Fill the same password in both fields.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AdminTbl set AdPass=@AP where AdId=@Akey", Con);
                    cmd.Parameters.AddWithValue("@AP", NewPassTb.Text);
                    cmd.Parameters.AddWithValue("@Akey", 1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Updated");
                    Con.Close();
                    NewPassTb.Text = "";
                    ConfirmPassTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            
        }

    }
}
