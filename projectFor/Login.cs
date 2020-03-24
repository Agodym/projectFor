using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectFor
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ExitBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnterBT_Click(object sender, EventArgs e)
        {
            bool enter=true;

            if (EmailTB.Text == "" || PasswordLB.Text =="") {
                MessageBox.Show("Неправильно ведён пароль или email адресс", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enter = false;
            }
            if (enter) { 
            
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmailTB.Text = "";
            PasswordTB.Text = "";
        }

        private void btsignup_Click(object sender, EventArgs e)
        {
            
        }
    }
}
