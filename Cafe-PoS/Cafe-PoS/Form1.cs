using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_PoS
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void txtUsernameIN_TextChanged(object sender, EventArgs e)
        {
            if(txtUsernameIN.Text == "Username")
            {
                txtUsernameIN.Text = "";
                txtUsernameIN.ForeColor = Color.White;
            }
        }

        private void txtUsernameIN_Leave(object sender, EventArgs e)
        {
            if (txtUsernameIN.Text == "")
            {
                txtUsernameIN.Text = "Username";
                txtUsernameIN.ForeColor = Color.Silver;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Stock stock = new Stock();
            stock.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
