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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lblHomeManageUserName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UserManage().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblHomeManageDonorName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DonorManage().Show();
            this.Hide();
            

        }

        private void lblHomeAboutName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new about().Show();
            this.Hide();
        }

        private void lblHomeExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
