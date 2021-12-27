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
    public partial class UserManage : Form
    {
        public UserManage()
        {
            InitializeComponent();
        }

        private void UserManage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUserBack_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAboutBack_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void lblUserUserID_Click(object sender, EventArgs e)
        {
           
        }
    }
}
