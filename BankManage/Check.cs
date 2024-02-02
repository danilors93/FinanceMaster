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

namespace BankManage
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        int Balance;
        private void BalanceLbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            {
                CheckBalTb.Text = "";
                BalanceLbl.Text = "Current Balance";
            }
        }
        private void CheckBalance()
        {
            Con.Open();
            string Query = "select * from AccountTbl where ACNum=" + CheckBalTb.Text + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BalanceLbl.Text = "$" + dr["AcBal"].ToString();
                Balance = Convert.ToInt32(dr["AcBal"].ToString());
            }
            Con.Close();
        }
        private void CheckBalBtn_Click(object sender, EventArgs e)
        {
            if (CheckBalTb.Text == "")
            {
                MessageBox.Show("Enter Account Number");
            }
            else
            {
                CheckBalance();
                if (BalanceLbl.Text == "Current Balance")
                {
                    MessageBox.Show("Account not Found");
                    CheckBalTb.Text = "";
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Transactions Obj = new Transactions();
            Obj.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Check_Load(object sender, EventArgs e)
        {

        }

        private void CheckBalTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
