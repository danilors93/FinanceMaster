using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace BankManage
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        int Balance;
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CheckBalance()
        {
            
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void Transactions_Load(object sender, EventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CheckAvaliableBal()
        {
           
        }
        private void AddBal()
        {
           
        }

        private void SubstractBal()
        {
            
        }
        private void GetNewBalance()
        {
           
        }

        private void CheckBalBtn_Click(object sender, EventArgs e)
        {
          
        }
        private void Deposit()
        {
          
        }
        private void Withdraw()
        {
         
        }
        private void DepositBtn_Click(object sender, EventArgs e)
        {
           
        }
        private void WdBtn_Click(object sender, EventArgs e)
        {
           
        }
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
           
        }
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
           
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void BalanceLabel_Click(object sender, EventArgs e)
        {
            
        }
        private void Transfer()
        {
            
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void WdAcNumDt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepositAccountTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {
            Check Obj = new Check();
            Obj.Show();
            this.Hide();
        }

        private void guna2PictureBox3_Click_1(object sender, EventArgs e)
        {
            withdrawForm Obj = new withdrawForm();
            Obj.Show();
            this.Hide();
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            DepositForm Obj = new DepositForm();
            Obj.Show();
            this.Hide();
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            TransferForm Obj = new TransferForm();
            Obj.Show();
            this.Hide();
        }
    }
}
