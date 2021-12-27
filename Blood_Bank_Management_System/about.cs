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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAboutBack_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
