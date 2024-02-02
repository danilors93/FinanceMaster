using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BankManage
{
    public partial class withdrawForm : Form
    {
        public withdrawForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        int Balance;

        private void WdAcNumDt_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateBalanceLabel()
        {
            Con.Open();
            string query = "SELECT AcBal FROM AccountTbl WHERE ACNum = @AccountNumber";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@AccountNumber", BalanceLbl.Text);
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                BalanceLbl.Text = "$" + result.ToString();
            }
            else
            {
                MessageBox.Show("Failed to retrieve updated balance.");
            }
            Con.Close();
        }
        private void CheckBalance()
        {
            Con.Open();
            string Query = "select * from AccountTbl where ACNum=" + BalanceLbl.Text + "";
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
        private void GetNewBalance()
        {
            if (WdAcNumDt.Text == "Current Balance")
            {
                MessageBox.Show("Invalid account number.");
                return;
            }

            Con.Open();
            string Query = "select * from AccountTbl where ACNum = @AccountNumber";
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.Parameters.AddWithValue("@AccountNumber", WdAcNumDt.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                Balance = Convert.ToInt32(dr["AcBal"]);
            }
            else
            {
                Balance = 0;
            }
            Con.Close();
        }
        private void Withdraw()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName,TDate,TAmt,TACNum)values(@TN,@TD,@TA,@TAC)", Con);
                cmd.Parameters.AddWithValue("@TN", "Withdrawl");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", WdAmtDt.Text); 
                cmd.Parameters.AddWithValue("@TAC", WdAcNumDt.Text); 
                cmd.ExecuteNonQuery();
                Con.Close();
                UpdateBalanceLabel(); 
            }
            catch (Exception Ex)
            {
                // MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }
        private void WdBtn_Click(object sender, EventArgs e)
        {
            if (WdAcNumDt.Text == "" || WdAmtDt.Text == "")
            {
                MessageBox.Show("Please Enter Account Number and Withdraw Amount.");
            }
            else
            {
                Withdraw();
                GetNewBalance();
                if (Balance < Convert.ToInt32(WdAmtDt.Text))
                {
                    MessageBox.Show("Insufficient Balance");
                }
                else
                {
                    int newBal = Balance - Convert.ToInt32(WdAmtDt.Text);
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AB where ACNum=@Ackey", Con);
                        cmd.Parameters.AddWithValue("@AB", newBal);
                        cmd.Parameters.AddWithValue("@Ackey", WdAcNumDt.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Withdrawl Completed!");
                        Con.Close();
                        WdAmtDt.Text = "";
                        WdAcNumDt.Text = "";
                        BalanceLbl.Text = "$" + newBal.ToString();
                    }
                    catch (Exception Ex)
                    {
                        // MessageBox.Show(Ex.Message);
                    }
                }
            }
        }

        private void BalanceLbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            BalanceLbl.Text = "Current Balance";
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
    }
}