using System;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;

namespace BankManage
{
    public partial class TransferForm : Form
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private int Balance;

        public TransferForm()
        {
            InitializeComponent();
        }
        private void AddBal()
        {
            try
            {
                int transferAmount = Convert.ToInt32(TransferAmtTb.Text);

                Con.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE AccountTbl SET AcBal = AcBal + @TransferAmt WHERE ACNum = @ToAccount", Con);
                cmd1.Parameters.AddWithValue("@TransferAmt", transferAmount);
                cmd1.Parameters.AddWithValue("@ToAccount", ToTb.Text);
                cmd1.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Transfer Completed");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void SubstractBal()
        {
            int transferAmount = Convert.ToInt32(TransferAmtTb.Text);
            int fromAccountBalance = Balance;

            if (fromAccountBalance < transferAmount)
            {
                MessageBox.Show("Insufficient Balance in the source account.");
                return;
            }

            int newBal = fromAccountBalance - transferAmount;

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE AccountTbl SET AcBal = @AB WHERE ACNum = @Ackey", Con);
                cmd.Parameters.AddWithValue("@AB", newBal);
                cmd.Parameters.AddWithValue("@Ackey", FromTb.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FromTb.Text) || string.IsNullOrWhiteSpace(ToTb.Text) || string.IsNullOrWhiteSpace(TransferAmtTb.Text))
            {
                MessageBox.Show("Fill in all the information");
                return;
            }

            CheckBalance();

            int transferAmount = Convert.ToInt32(TransferAmtTb.Text);

            if (transferAmount > Balance)
            {
                MessageBox.Show("Insufficient Balance");
                return;
            }

            Transfer();
            SubstractBal();
            AddBal();

            FromTb.Text = "";
            ToTb.Text = "";
            TransferAmtTb.Text = "";
            BalanceLabel.Text = "Balance";
        }
        private void CheckBalance()
        {
            Con.Open();
            string Query = "SELECT * FROM AccountTbl WHERE ACNum = @ACNum";
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.Parameters.AddWithValue("@ACNum", FromTb.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
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
        private void Transfer()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TransferTbl (TrSrc, TrDest, TrAmt, TrDate) VALUES (@TS, @TD, @TA, @TDa)", Con);
                cmd.Parameters.AddWithValue("@TS", FromTb.Text);
                cmd.Parameters.AddWithValue("@TD", ToTb.Text);
                cmd.Parameters.AddWithValue("@TA", TransferAmtTb.Text);
                cmd.Parameters.AddWithValue("@TDa", DateTime.Now.Date);
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FromTb.Text))
            {
                MessageBox.Show("Enter Source Account");
                return;
            }

            CheckAvaliableBal();
        }
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            if (ToTb.Text == "")
            {
                MessageBox.Show("Enter Beneficiary Account");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count (*) from AccountTbl where ACNum='" + ToTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Beneficiary found. Enter the amount to transfer.");
                    Con.Close();
                    if (ToTb.Text == FromTb.Text)
                    {
                        MessageBox.Show("The depositor cannot be the beneficiary of the transfer");
                    }
                }
                else
                {
                    MessageBox.Show("Account does not Exist");
                    ToTb.Text = "";
                }
                Con.Close();
            }
        }
        private void CheckAvaliableBal()
        {
            string Query = "SELECT * FROM AccountTbl WHERE ACNum = @ACNum";
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.Parameters.AddWithValue("@ACNum", FromTb.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                BalanceLabel.Text = "$" + dt.Rows[0]["AcBal"].ToString();
                Balance = Convert.ToInt32(dt.Rows[0]["AcBal"]);
            }
            else
            {
                MessageBox.Show("Account does not Exist");
                FromTb.Text = "";
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Transactions Obj = new Transactions();
            Obj.Show();
            this.Hide();
        }
    }
}
