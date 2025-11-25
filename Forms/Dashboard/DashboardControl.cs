using DSAFinalRequirement.Classes.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Dashboard
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            LoadUserSession();
        }
        private void LoadUserSession()
        {
            lblWelcom.Text = $"Welcome {Session.Username}!";
            
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {

        }


    }
}
