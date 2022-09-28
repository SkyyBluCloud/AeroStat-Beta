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

namespace AeroStat_Beta
{
    public partial class UserDashboardForm : Form
    {
        List<User> users = new List<User>();

        public UserDashboardForm()
        {
            InitializeComponent();

            updateBinding();
        }

        private void updateBinding()
        {
            DataAccess da = new DataAccess();

            users = da.getUsers();

            lbUsers.DataSource = users;
            lbUsers.DisplayMember = "certName";
        }

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
