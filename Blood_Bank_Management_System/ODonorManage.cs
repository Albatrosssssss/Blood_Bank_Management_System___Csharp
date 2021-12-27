using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer.Operation
{
    public class ODonorManage
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");
        public int insert(EDonorManage eDonorManage)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into DonorManage values (' " + eDonorManage.Donor_User_ID + "' ,'" + eDonorManage.DonorName + "','" + eDonorManage.DonorEmail + "','" + eDonorManage.DonorContact + "','" + eDonorManage.BloodGrp + "','" + eDonorManage.DonorAddress + "') ", connection);
            int number = command.ExecuteNonQuery();
            connection.Close();
            return number;
        }
        public SqlDataAdapter show()
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from DonorManage ", connection);
            connection.Close();
            return sqlDataAdapter;
        }

    }
}




//Create Static String to Connect Database
//static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
/*#region
public DataTable select() {
    // Create object to DataTAble to hold the data from database and return it
    DataTable dt = new DataTable();
    //Create object of SQL Connection to Connect DAtabase
    SqlConnection Connection = new SqlConnection();
    try
    {
        string sql = "select * from DonorManage";
        SqlCommand cmd = new SqlCommand(sql,Connection);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //transfer adapter to data table
        Connection.Open();
        adapter.Fill(dt);
    }
    catch (Exception ex)
    {
        //Display error messege
        MessageBox.Show(ex.Message);
    }
    finally
    {
        Connection.Close();
    }

    return dt;
}
#endregion*/
/*#region
public bool Insert(EDonorManage DM)
{
    //create bool variable
    bool isSuccess = false;
    SqlConnection connection = new SqlConnection();
    try
    {
        //Write the Query to INSERT data into database
        string sql = "INSERT INTO DonorManage (Donor_User_ID, Donor_Name,Donor_Email,Donor_Contact,Donor_Blood_Group,Donor_Address) VALUES (@txtManageDonorUserID, @txtDonorName, @txtDonorEmail, @txtDonorContact, @cboxBloodGrp, @txtDonorAddress)";
        //Create SQL Command to Execute the Query
        SqlCommand cmd = new SqlCommand(sql, connection);
        //Pass the value to SQL Query

        cmd.Parameters.AddWithValue("@Donor_User_ID", DM.txtManageDonorUserID);
        cmd.Parameters.AddWithValue("@Donor_Name", DM.txtDonorName);
        cmd.Parameters.AddWithValue("@Donor_Email", DM.txtDonorEmail);
        cmd.Parameters.AddWithValue("@Donor_Contact", DM.txtDonorContact);
        cmd.Parameters.AddWithValue("@Donor_Blood_Group", DM.cboxBloodGrp);
        cmd.Parameters.AddWithValue("@Donor_Address", DM.txtDonorAddress);

        //Open DAtabase Connection
        connection.Open();
        //Create an Integer Variable to Check whether the query was executed Successfully or Not
        int rows = cmd.ExecuteNonQuery();

        //If the Query is Executed Successfully the value of rows willb e greater than Zero else it will be Zero
        if (rows > 0)
        {
            //Query Executed Successfully
            isSuccess = true;
        }
        else
        {
            //Failed to Execute Query
            isSuccess = false;
        }
    }
    catch(Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        connection.Close();
    }
    return isSuccess;
}
#endregion
#region Update Donor In Database
public bool Update(EDonorManage DM)
{
    // Create a Boolean Variable and SEt its Default Value to FAlse
    bool isSuccess = false;
    //Create SQLConnection to Connect DAtabase
    SqlConnection connection = new SqlConnection(myconnstrng);
    try
    {
        string cmd = "UPDATE DonorMan SET txtManageDonorUserID=@Donor_User_Id, txtDonorName=@Donor_Name,txtDonorEmail=@Donor_Email, txtDonorContact=@Donor_Contact, cboxBloodGrp=@Donor_Blood_Group, txtDonorAddress=@Donor_Address WHERE txtManageDonorUserID=@Donor_User_Id";
        cmd.Parameters.AddWithValue("@Donor_User_ID", DM.txtManageDonorUserID);
        cmd.Parameters.AddWithValue("@Donor_Name", DM.txtDonorName);
        cmd.Parameters.AddWithValue("@Donor_Email", DM.txtDonorEmail);
        cmd.Parameters.AddWithValue("@Donor_Contact", DM.txtDonorContact);
        cmd.Parameters.AddWithValue("@Donor_Blood_Group", DM.cboxBloodGrp);
        cmd.Parameters.AddWithValue("@Donor_Address", DM.txtDonorAddress);

    }
    catch
    {

    }
    finally
    {

    }
    return isSuccess;
}
#endregion*/


