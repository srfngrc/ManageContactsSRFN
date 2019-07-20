using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//step 1. import ADO.NET controls
using System.Data.SqlClient;
//Also import data controls: DataTable
using System.Data;

namespace ContactManagerSRFN
{
    public partial class Login : Form
    {
        string ConnectionStringSRFN = 
            "Server=DatabaseSRFN.mssql.somee.com;" +
                "Database=DatabaseSRFN;" +
                "User Id=serafin;" +
                "Password = 19771977; ";
        public Login()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            SqlConnection SRFNconnection = new SqlConnection();

            //WE ARE GONNA USE 3 PROPERTIES OF SQLCONNECTION:
            //myconnection.ConnectionString;
            //myconnection.Open();
            //myconnection.Close();

            //myconnection.ConnectionString = 
            //    "Server=myServerAddress;" +
            //    "Database=myDataBase;" +
            //    "User Id=myUsername;" +
            //    "Password = myPassword; ";
            // I looked for it at ConnectionString.com
            SRFNconnection.ConnectionString = ConnectionStringSRFN;

            //THIS ONE WOULD ALSO WORK
            //SqlConnection SRFNconnection = new SqlConnection(ConnectionStringSRFN);
            //OR EVEN THIS ONE:
            //SqlConnection SRFNconnection = new SqlConnection("Server =DatabaseSRFN.mssql.somee.com;Database=DatabaseSRFN;User Id=serafin;Password = 19771977;");

            try
            {
                SRFNconnection.Open();
                //OPEN THE CONNECTION. always close it before going out (just if its open)
                //PERFORM THE COMMAND
                MessageBox.Show("connection should be already OPEN");
                //SqlCommand SRFNcommand = new SqlCommand("SELECT * FROM Login;");
                SqlCommand SRFNcommand = new SqlCommand();
                //COMMAND PROP1
                SRFNcommand.CommandText = String.Format(
                    "SELECT * FROM Login WHERE UserId='{0}' AND Password='{1}'",
                    TB_User.Text.Trim().Replace("\"","").Replace(";",""),
                    TB_Password.Text.Trim().Replace("\"","").Replace("; ","")
                    );
                MessageBox.Show("Data inserted...: " + TB_User.Text + "...." + TB_Password.Text);
                //COMMAND PROP2
                SRFNcommand.Connection = SRFNconnection;

                //----------------------------------
                SqlDataReader SRFNdatareader = SRFNcommand.ExecuteReader();
                if (SRFNdatareader.Read())
                {
                    MessageBox.Show("YEAHHHHHHHHHHHHHHHHHHHH.Logged in");
                    myInfo infoFromLogin = new myInfo();
                    infoFromLogin.loginMessage = "Welcome!! you are:" + TB_User.Text;

                    //Pass it on!
                    Main newFrom = new Main(infoFromLogin);
                    newFrom.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("THERE ARE NO USER LOGINS IN THE DATABASE Logins");
                }
            }
            catch (Exception eex)
            {
                //CATCH ANY ERRORS AND DEBUG
                MessageBox.Show("oHHHHHHHHHHHHHHHHHHHHHHHHHH");
            }
            finally
            {
                if (SRFNconnection.State == ConnectionState.Open)
                {
                    SRFNconnection.Close();
                }
            }
        }
    }
}
