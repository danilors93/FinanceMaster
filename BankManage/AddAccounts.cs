using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankManage
{
    public partial class AddAccounts : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void DisplayAccounts()
        {
            Con.Open();
            string Query = "Select * from AccountTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query,Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AccountDVG.DataSource = ds.Tables[0];
            Con.Close();
        }
        public AddAccounts()
        {
            InitializeComponent();
            DisplayAccounts();
            AccountDVG.DataBindingComplete += AccountDVG_DataBindingComplete;
        }
        private void AccountDVG_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AccountDVG.Columns["ACNum"].HeaderText = "Account";
            AccountDVG.Columns["ACName"].HeaderText = "Name";
            AccountDVG.Columns["ACPhone"].HeaderText = "Phone";
            AccountDVG.Columns["ACAddress"].HeaderText = "Address";
            AccountDVG.Columns["ACGen"].HeaderText = "Gender";
            AccountDVG.Columns["ACOccup"].HeaderText = "Occupation";
            AccountDVG.Columns["ACEduc"].HeaderText = "Education";
            AccountDVG.Columns["ACInc"].HeaderText = "Income";
            AccountDVG.Columns["ACBal"].HeaderText = "Balance";
        }
        private void Reset()
        {
            AcNameTb.Text = "";
            AcPhoneTb.Text = "";
            AcAddressTb.Text = "";
            GenderCb.SelectedIndex = -1;
            OccupationTb.Text = "";
            IncomeTb.Text = "";
            EducationCb.SelectedIndex = -1;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(AcNameTb.Text == "" ||  AcPhoneTb.Text == "" || AcAddressTb.Text == "" || GenderCb.SelectedIndex == -1 || OccupationTb.Text == "" || EducationCb.SelectedIndex == -1 || IncomeTb.Text == "")
            {
                MessageBox.Show("Please fill all the information correctly.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AccountTbl(ACName,ACPhone,ACAddress,ACGen,ACOccup,ACEduc,ACInc,ACBal)values(@AN,@AP,@AA,@AG,@AO,@AE,@AI,@AB)", Con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AcPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AcAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", OccupationTb.Text);
                    cmd.Parameters.AddWithValue("@AE", EducationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", IncomeTb.Text);
                    cmd.Parameters.AddWithValue("@AB", 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account successfully created!");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int key = 0;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Account.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AccountTbl where AcNum=@Ackey", Con);
                    cmd.Parameters.AddWithValue("@Ackey", key);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account successfully deleted!");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AccountDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AcNameTb.Text = AccountDVG.SelectedRows[0].Cells[1].Value.ToString();
            AcPhoneTb.Text = AccountDVG.SelectedRows[0].Cells[2].Value.ToString();
            AcAddressTb.Text = AccountDVG.SelectedRows[0].Cells[3].Value.ToString();
            GenderCb.SelectedItem = AccountDVG.SelectedRows[0].Cells[4].Value.ToString();
            OccupationTb.Text = AccountDVG.SelectedRows[0].Cells[5].Value.ToString();
            EducationCb.SelectedItem = AccountDVG.SelectedRows[0].Cells[6].Value.ToString();
            IncomeTb.Text = AccountDVG.SelectedRows[0].Cells[7].Value.ToString();
            if (AcNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AccountDVG.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if(AcNameTb.Text == "" ||  AcPhoneTb.Text == "" || AcAddressTb.Text == "" || GenderCb.SelectedIndex == -1 || OccupationTb.Text == "" || EducationCb.SelectedIndex == -1 || IncomeTb.Text == "")
            {
                MessageBox.Show("Please fill all the information correctly.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set ACName=@AN,ACPhone=@AP,ACAddress=@AA,ACGen=@AG,ACOccup=@AO,ACEduc=@AE,ACInc=@AI where ACNum=@Ackey", Con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AcPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AcAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", OccupationTb.Text);
                    cmd.Parameters.AddWithValue("@AE", EducationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", IncomeTb.Text);
                    cmd.Parameters.AddWithValue("@Ackey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account successfully Updated!");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
