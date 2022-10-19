using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class UserDashboardForm : MaterialForm
    {
        List<User> users = new List<User>();
        MaterialSkinManager skinManager;
        public UserDashboardForm()
        {
            InitializeComponent();
            
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            updateBindings();
        }

        private void updateBindings()
        {
            DataAccess da = new DataAccess();

            users = da.getUsers();

            mlvUsers.Items.Clear();
            foreach (User u in users)
            {
                ListViewItem item = new ListViewItem(u.firstName);
                item.SubItems.Add(u.lastName);
                item.SubItems.Add(u.opInitials);
                item.SubItems.Add(u.lastLogin.ToString());
                mlvUsers.Items.Add(item);
            }

        }
    }
}
