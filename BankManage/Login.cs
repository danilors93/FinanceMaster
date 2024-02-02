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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";
            RoleCB.SelectedIndex = -1;
            RoleCB.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (RoleCB.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Roll");
            } 
            else if (RoleCB.SelectedIndex == 0)
            {
                if (UNameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter Admin Name and Password");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count (*) from AdminTbl where AdName='"+UNameTb.Text+"' and AdPass='"+PasswordTb.Text+"'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Agents Obj = new Agents();
                        Obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Admin Name or Password");
                        UNameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                    Con.Close();
                }
            }
            else
            {
                if (UNameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter User Name and Password");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count (*) from AgentTbl where AName='" + UNameTb.Text + "' and APass='" + PasswordTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MainMenu Obj = new MainMenu();
                        Obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect User Name or Password");
                        UNameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                    Con.Close();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
