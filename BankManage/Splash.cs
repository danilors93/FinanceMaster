using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MyProgress_ValueChanged(object sender, EventArgs e)
        {

        }
        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            MyProgress.Value = startP;
            if (MyProgress.Value == 100) 
            {
                MyProgress.Value = 0;
                Login obj = new Login();
                obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Interval = 30;
            timer1.Start();
        }
    }
}
