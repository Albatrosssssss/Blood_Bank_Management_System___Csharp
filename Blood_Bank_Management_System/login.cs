using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void lblloginName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoginBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
