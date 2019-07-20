using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Main(myInfo infoFromLogin)
        {
            InitializeComponent();
            userInfo = infoFromLogin;
            //Example of use
            lblMessage.Text = userInfo.loginMessage;
        }
    }
}
