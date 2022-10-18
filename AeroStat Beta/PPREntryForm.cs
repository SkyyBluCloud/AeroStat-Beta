using MaterialSkin;
using MaterialSkin.Controls;

namespace AeroStat_Beta
{
    public partial class PPREntryForm : MaterialForm
    {
        private readonly MaterialSkinManager skinManager;

        public PPREntryForm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
        }

        private void PPREntryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
