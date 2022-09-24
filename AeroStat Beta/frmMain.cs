namespace AeroStat_Beta
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDashboardForm frmUserDashboard = new();
            frmUserDashboard.ShowDialog();
        }
    }
}