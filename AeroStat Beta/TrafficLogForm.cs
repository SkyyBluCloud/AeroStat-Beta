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
    }
}
