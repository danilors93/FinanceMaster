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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        int Balance;
        private void BalanceLbl_Click(object sender, EventArgs e)
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
            if (DepositAccountTb.Text == "Current Balance")
            {
                MessageBox.Show("Invalid account number.");
                return;
            }

            Con.Open();
            string Query = "select * from AccountTbl where ACNum = @AccountNumber";
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.Parameters.AddWithValue("@AccountNumber", DepositAccountTb.Text);
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
        private void Deposit()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName,TDate,TAmt,TACNum)values(@TN,@TD,@TA,@TAC)", Con);
                cmd.Parameters.AddWithValue("@TN", "Deposit");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", DepositAmountTb.Text);
                cmd.Parameters.AddWithValue("@TAC", DepositAmountTb.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }
        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (DepositAccountTb.Text == "" || DepositAmountTb.Text == "")
            {
                MessageBox.Show("Please Enter Account Number and Deposit Amount.");
            }
            else
            {
                Deposit();
                GetNewBalance();
                int newBal = Balance + Convert.ToInt32(DepositAmountTb.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AB where ACNum=@Ackey", Con);
                    cmd.Parameters.AddWithValue("@AB", newBal);
                    cmd.Parameters.AddWithValue("@Ackey", DepositAccountTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deposit Completed!");
                    Con.Close();
                    DepositAmountTb.Text = "";
                    DepositAccountTb.Text = "";
                    BalanceLbl.Text = "$" + newBal.ToString();
                }
                catch (Exception Ex)
                {
                   // MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DepositAccountTb.Text = "";
            DepositAmountTb.Text = "";
            BalanceLbl.Text = "Current Balance";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Transactions Obj = new Transactions();
            Obj.Show();
            this.Hide();
        }
    }
}
