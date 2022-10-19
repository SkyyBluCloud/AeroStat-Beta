using AeroStat_Beta.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace AeroStat_Beta
{
    public partial class PPREntryForm : MaterialForm
    {
        private readonly MaterialSkinManager skinManager;
        private List<PPRService> services = new();

        public PPREntryForm(int? id)
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            

            newRec = id == null;

            updateBindings();


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

                        case string s when s is "mtbCallsign" or "mtbTail":
                            fail = mtbCallsign.TextLength == 0 && mtbTail.TextLength == 0;
                            break;

                        case string s when s is "mtbType" or "mtbDepPoint" or "mtbArrDate" or "pocName" or "ctcInfo" or "pprNumber":
                            fail = mtb.TextLength == 0;
                            break;
                        case "fuel":
                            fail = mtb.TextLength == 0;
                            break;
                        case string s when s is "depPoint" or "destination":
                            fail = mtb.Text == settings.Default.station;
                            break;
                    }
                }
            });

            return !fail;
        }
        private void updateBindings()
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

