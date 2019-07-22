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
        public Main(myInfo infoFromLogin)
        {
            InitializeComponent();
            userInfo = infoFromLogin;
            //Example of use
            lblMessage.Text = userInfo.loginMessage;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
