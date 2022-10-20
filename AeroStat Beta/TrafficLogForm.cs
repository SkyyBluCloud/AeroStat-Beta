using MaterialSkin;

namespace AeroStat_Beta
{
    public partial class TrafficLogForm : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager skinManager;
        public TrafficLogForm()
        {
            InitializeComponent();

            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
        }

        private void frmTrafficLog_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void mlvPPR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mlvFlightOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mlvStationed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mlvLocalStereoRequest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
