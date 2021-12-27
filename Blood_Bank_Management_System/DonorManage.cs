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
    public partial class DonorManage : Form
    {
        public DonorManage()
        {
            InitializeComponent();
        }

        private void lblDonorUserID_Click(object sender, EventArgs e)
        {

        }

        private void DonorManage_Load(object sender, EventArgs e)
        {

        }

        private void lblDonorName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDonorBack_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnDonorAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sahdajk");
        }
    }
}
