using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            lstUsers.DataSource = users;
            lstUsers.DisplayMember = "fullName3616";
        }

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            DataAccess db = new();

            users = db.getUsers();
            updateBinding();
        }
    }
}
