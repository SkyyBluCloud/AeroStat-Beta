using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;

namespace AeroStat_Beta
{
    public partial class Main : MaterialForm
    {
        private readonly MaterialSkinManager skinManager;
        public Main()
        {
            InitializeComponent();

            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.BlueGrey100, Accent.LightBlue200, TextShade.WHITE);

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDashboardForm frmUserDashboard = new()
            {
                //MdiParent = this
            };
            frmUserDashboard.Show();
        }

        private void trafficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrafficLogForm frmTrafficLog = new()
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            frmTrafficLog.Show();
        }

        private void pPRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialInputBox mib = new("Enter PPR number:");
            
            if (mib.ShowDialog(this) == DialogResult.OK)
            {
                PPREntryForm frmPPREntry = new(mib.result);
                frmPPREntry.Show();
            }
            mib.Dispose();
        }

        private void mbTraffic_Click(object sender, EventArgs e)
        {
            TrafficLogForm frmTrafficLog = new()
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            frmTrafficLog.Show();
        }
    }
}