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

namespace ContactManagerSRFN
{
    public partial class Main : Form
    {
        myInfo userInfo;
        string ConnectionStringSRFN =
            "Server=DatabaseSRFN.mssql.somee.com;" +
                "Database=DatabaseSRFN;" +
                "User Id=serafin;" +
                "Password = 19771977; ";
        private SqlConnection miconex;


        public Main(myInfo infoFromLogin)
        {
            InitializeComponent();
            userInfo = infoFromLogin;
            //Example of use
            lblMessage.Text = userInfo.loginMessage;
        }

        private void GetContacts()
        {
            SqlConnection myconnection = new SqlConnection();
            myconnection.ConnectionString = ConnectionStringSRFN;

            try
            {
                myconnection.Open();
                //this part changes accordingly
                //Select
                //update
                //insert
                //delete

                //Step 1: Define the query
                string query = "SELECT * FROM Contact ORDER BY LastName";

                //Step 2: Create and inizializate the command object 
                SqlCommand myCommand = new SqlCommand();
                myCommand.CommandText = query;
                myCommand.Connection = myconnection;
                //Step 3: Create datatable that will contain the data
                DataTable myTable = new DataTable();
                //myTable.Columns.Add("ID");
                //myTable.Columns.Add(new DataColumn("FirstName"));
                //myTable.Columns.Add(new DataColumn("LastName"));
                ////myTable.Columns.Add(new DataColumn("ID"));
                //myTable.Columns.Add(new DataColumn("Phone"));
                //myTable.Columns.Add(new DataColumn("Email"));

                //Step 4: Fill in the datatable with information from the DataBase
                SqlDataReader myReader = myCommand.ExecuteReader();

                myTable.Load(myReader);
                dgContacts.DataSource = myTable;



                //while (myReader.Read())
                //{
                //    DataRow contact = myTable.NewRow();
                //    contact["ID"] = myReader["ID"];
                //    contact["FirstName"] = myReader["FirstName"];
                //    contact["LastName"] = myReader["LastName"];
                //    contact["Phone"] = myReader["Phone"];
                //    contact["Email"] = myReader["Email"];
                //    myTable.Rows.Add(contact);
                //}

                ////Step 5: Bind datatable to datagridview
                ////IMPORTANTTTTTTTTTTTTTTTTTTTTTTT
                //dgContacts.DataSource = myTable;

            }
            catch (Exception ex123)
            {
                MessageBox.Show(ex123.Message);
            }
            finally
            {
                if (myconnection.State == ConnectionState.Open)
                {
                    myconnection.Close();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            GetContacts();

        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {

            string InsertQuery = "INSERT INTO Contact (FirstName, LastName, Phone, Email)" +
                " VALUES ('{0}','{1}','{2}','{3}')";
            InsertQuery = string.Format(InsertQuery,
                TBfirstname.Text,
                TBlastname.Text,
                TBphone.Text,
                TBmail.Text);

            SqlConnection miconex = new SqlConnection(ConnectionStringSRFN);

            try
            {
                miconex.Open();

                if (TBfirstname.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a name");
                    return;
                }
                if (TBlastname.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a last name");
                    return;
                }
                if (TBphone.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a phone");
                    return;
                }
                if (TBmail.Text == string.Empty)
                {
                    MessageBox.Show("Please enter an email");
                    return;
                }

                SqlCommand micommand = new SqlCommand(InsertQuery, miconex);
                micommand.ExecuteNonQuery();
            }
            catch (Exception aaa)
            {
                MessageBox.Show(aaa.Message);
            }
            finally
            {
                if (miconex.State == ConnectionState.Open)
                {
                    miconex.Close();
                    GetContacts();
                }
            }
            TBfirstname.Text = string.Empty;
            TBlastname.Text = string.Empty;
            TBphone.Text = string.Empty;
            TBmail.Text = string.Empty;
        }
    }
}
