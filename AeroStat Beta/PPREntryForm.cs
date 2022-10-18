using MaterialSkin;
using MaterialSkin.Controls;

namespace AeroStat_Beta
{
    public partial class PPREntryForm : MaterialForm
    {
        private readonly MaterialSkinManager skinManager;
        private DataAccess dataAccess = new();
        private List<PPRService> services = new List<PPRService>();

        public PPREntryForm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            services = dataAccess.getPPRServices();
            
            foreach(PPRService service in services)
            {
                MaterialListBoxItem item = new MaterialListBoxItem()
                {
                    Tag = service.id,
                    Text = service.service,
                    SecondaryText = service.description
                };
                mlbServices.Items.Add(item);
            }
        }
        public bool newRec { get; set; } = true;
    }
}
