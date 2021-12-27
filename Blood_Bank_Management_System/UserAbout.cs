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
    public partial class AboutUser : Form
    {
        public AboutUser()
        {
            InitializeComponent();
        }

        private void btnAboutBack_Click(object sender, EventArgs e)
        {
            new UserInterface().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void txtAboutDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
