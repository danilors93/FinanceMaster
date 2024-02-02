using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace BankManage
{
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            DisplayAgents();
            AgentsDGV.DataBindingComplete += AgentsDGV_DataBindingComplete;
            AgentsDGV.CellFormatting += AgentsDGV_CellFormatting;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void DisplayAgents()
        {
            Con.Open();
            string Query = "Select * from AgentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AgentsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void AgentsDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AgentsDGV.Columns["AId"].HeaderText = "ID";
            AgentsDGV.Columns["AName"].HeaderText = "Name";
            AgentsDGV.Columns["APass"].HeaderText = "Password";
            AgentsDGV.Columns["APhone"].HeaderText = "Phone";
            AgentsDGV.Columns["AAddress"].HeaderText = "Address";
        }
        private void AgentsDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (AgentsDGV.Columns[e.ColumnIndex].Name == "APass" && e.Value != null)
            {
                string password = e.Value.ToString();
                if (password.Length > 2)
                {
                    string maskedPassword = new string('*', password.Length - 2) + password.Substring(password.Length - 2);
                    e.Value = maskedPassword;
                }
                else
                {
                    e.Value = new string('*', password.Length);
                }
            }
        }
        private void Reset()
        {
            ANameTb.Text = "";
            APasswordTb.Text = "";
            AAddressTb.Text = "";
            APhoneTb.Text = "";
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (ANameTb.Text == "" || APasswordTb.Text == "" || APhoneTb.Text == "" || AAddressTb.Text == "")
            {
                MessageBox.Show("Please fill all the information correctly.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AgentTbl(AName,APass,APhone,AAddress)values(@AN,@APA,@APH,@AA)", Con);
                    cmd.Parameters.AddWithValue("@AN", ANameTb.Text);
                    cmd.Parameters.AddWithValue("@APA", APasswordTb.Text);
                    cmd.Parameters.AddWithValue("@APH", APhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AAddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Added");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to change Users?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                Login Obj = new Login();
                Obj.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Agent.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AgentTbl where AId=@Akey", Con);
                    cmd.Parameters.AddWithValue("@Akey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent deleted!");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void AgentsDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ANameTb.Text = AgentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            APasswordTb.Text = AgentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            APhoneTb.Text = AgentsDGV.SelectedRows[0].Cells[3].Value.ToString();
            AAddressTb.Text = AgentsDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (ANameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AgentsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ANameTb.Text == "" || APasswordTb.Text == "" || APhoneTb.Text == "" || AAddressTb.Text == "")
            {
                MessageBox.Show("Please fill all the information correctly.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AgentTbl set AName=@AN,APass=@APA,APhone=@APH,AAddress=@AA where AId=@Akey", Con);
                    cmd.Parameters.AddWithValue("@AN", ANameTb.Text);
                    cmd.Parameters.AddWithValue("@APA", APasswordTb.Text);
                    cmd.Parameters.AddWithValue("@APH", APhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AAddressTb.Text);
                    cmd.Parameters.AddWithValue("@Akey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Updated!");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SettingsLbl_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();
        }
    }
}
