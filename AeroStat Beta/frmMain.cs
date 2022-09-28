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
            frmUserDashboard.MdiParent = this;
            frmUserDashboard.Show();
        }

        private void airTrafficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrafficLog frmTrafficLog = new frmTrafficLog();
            frmTrafficLog.MdiParent = this;
            frmTrafficLog.Show();
        }
    }
}