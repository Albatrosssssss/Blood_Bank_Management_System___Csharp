using BloodManagmentDataAccessLayer.Entity;
using BloodManagmentDataAccessLayer.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void btnDonorClear_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtDonorName.Text = "";
            txtDonorAge.Text = "";
            cboxDonorGender.Text = "";
            txtDonorContact.Text = "";
            cboxBloodGrp.Text = "";
            txtDonorAddress.Text = "";
        }

        private void btnDonorAdd_Click(object sender, EventArgs e)
        {
            Eusername eDonor = new Eusername();
            eDonor.User_Id = txtUserID.Text;
            eDonor.Name = txtDonorName.Text;
            eDonor.Age = txtDonorAge.Text;
            eDonor.Gender = cboxDonorGender.Text;
            eDonor.Contact = txtDonorContact.Text;
            eDonor.Blood_Group = cboxBloodGrp.Text;
            eDonor.Address = txtDonorAddress.Text;

            ODonor oDonor = new ODonor();
            int number = oDonor.insert(eDonor);


            if (number >= 0)
            {

                if (txtUserID.Text == "" || txtDonorName.Text == "" || txtDonorAge.Text == "" || cboxDonorGender.SelectedIndex == -1 || txtDonorContact.Text == "" || cboxBloodGrp.SelectedIndex == -1 || txtDonorAddress.Text == "")
                {

                    MessageBox.Show("Missing Information");

                }
                else
                {
                    if ((txtDonorContact.Text.Length < 10) && (txtDonorContact.Text.StartsWith("0")))
                    {
                        /*LblErr.Text = "Enter Correct Mobile Number";
                        return;*/
                        MessageBox.Show("Enter a valid Number");
                    }
                    else
                    {
                        MessageBox.Show("Insert Successfully");
                    }

                }


            }
            else
            {
                MessageBox.Show("Error");
            }
            /*Eusername eDonor = new Eusername();
            eDonor.User_Id = txtUserID.Text;
            eDonor.Name = txtDonorName.Text;
            eDonor.Age = txtDonorAge.Text;
            eDonor.Gender = cboxDonorGender.Text;
            eDonor.Contact = txtDonorContact.Text;
            eDonor.Blood_Group = cboxBloodGrp.Text;
            eDonor.Address = txtDonorAddress.Text;

            ODonor oDonor = new ODonor();
            int number = oDonor.insert(eDonor);


            if (number >= 0)
            {

                if (txtUserID.Text == "" || txtDonorName.Text == "" || txtDonorAge.Text == "" || cboxDonorGender.SelectedIndex == -1 || txtDonorContact.Text == "" || cboxBloodGrp.SelectedIndex == -1 || txtDonorAddress.Text == "")
                {

                    MessageBox.Show("Missing Information");

                }
                else
                {
                    MessageBox.Show("Insert Successfully");
                }


            }
            else
            {
                MessageBox.Show("Error");
            }*/
        }

        private void btnDonorUpdate_Click(object sender, EventArgs e)
        {
            Eusername eDonor = new Eusername();
            eDonor.User_Id = txtUserID.Text;
            eDonor.Name = txtDonorName.Text;
            eDonor.Age = txtDonorAge.Text;
            eDonor.Gender = cboxDonorGender.Text;
            eDonor.Contact = txtDonorContact.Text;
            eDonor.Blood_Group = cboxBloodGrp.Text;
            eDonor.Address = txtDonorAddress.Text;

            ODonor oDonor = new ODonor();
            int number4 = oDonor.update(eDonor);

            if (number4 >= 0)
            {
                MessageBox.Show("Update Successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDonorDelete_Click(object sender, EventArgs e)
        {
            Eusername eDonor = new Eusername();
            eDonor.User_Id = txtUserID.Text;
            eDonor.Name = txtDonorName.Text;
            eDonor.Age = txtDonorAge.Text;
            eDonor.Gender = cboxDonorGender.Text;
            eDonor.Contact = txtDonorContact.Text;
            eDonor.Blood_Group = cboxBloodGrp.Text;
            eDonor.Address = txtDonorAddress.Text;

            ODonor oDonor = new ODonor();
            int check = oDonor.delete(eDonor);
            if (check >= 0)
            {
                MessageBox.Show("Delete Successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDonorShow_Click(object sender, EventArgs e)
        {
            ODonor oDonor = new ODonor();
            SqlDataAdapter sql = oDonor.show();
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dgvDonorShow.DataSource = dataTable;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void lblHomeAboutName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AboutUser().Show();
            this.Hide();
        }

        private void lblHomeExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
