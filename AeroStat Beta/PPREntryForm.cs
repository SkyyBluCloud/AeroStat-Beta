using AeroStat_Beta.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Linq.Expressions;

namespace AeroStat_Beta
{
    public partial class PPREntryForm : MaterialForm
    {
        private readonly MaterialSkinManager skinManager;
        private List<PPRService> services = new();

        
        public PPREntryForm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            bsPPR.DataSource = new PPR();
            
            newRec = true;

            mxpPPR.Description = "New PPR";
            updatePPRServiceList();
        }
        public PPREntryForm(string pprNumber)
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            DataAccess da = new();
            bsPPR.DataSource = da.pprExists(pprNumber) ? da.getPPR(pprNumber) : new PPR();
            mxpPPR.Description = pprNumber;
            updatePPRServiceList();
        }
        
        private bool qualityCheck()
        {
            bool fail = new();
            this.forAllControls(c =>
            {
                if (c.GetType() == typeof(MaterialTextBox))
                {
                    MaterialTextBox mtb = (MaterialTextBox)c;
                    switch (mtb.Name)
                    {
                        case "pprNumber":
                            //Do lookup stuff
                            break;

                        case "mtbCallsign" or "mtbTail":
                            fail = mtbCallsign.TextLength == 0 && mtbTail.TextLength == 0;
                            break;

                        case "mtbType" or "mtbDepPoint" or "mtbArrDate" or "pocName" or "ctcInfo" or "pprNumber":
                            fail = mtb.TextLength == 0;
                            break;
                        case "fuel":
                            fail = mtb.TextLength == 0;
                            break;
                        case "depPoint" or "destination":
                            fail = mtb.Text == settings.Default.station;
                            break;
                    }
                }
            });

            return !fail;
        }
        private void updatePPRServiceList()
        {
            DataAccess dataAccess = new();
            services = dataAccess.getPPRServices();

            mlbServices.Items.Clear();
            foreach(PPRService service in services)
            {
                MaterialListBoxItem item = new()
                {
                    Tag = service.id,
                    Text = service.service,
                    SecondaryText = service.description
                };

                mlbServices.Items.Add(item);
            }
        }

    public bool newRec { get; set; }

    }
}

