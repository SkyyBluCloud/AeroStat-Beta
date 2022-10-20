using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.CompilerServices;

namespace AeroStat_Beta
{
    public partial class MaterialInputBox : MaterialForm
    {
        MaterialSkinManager skinManager;
        public string result { get; set; } = "";
        public MaterialInputBox(string label)
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            mLabel.Text = label;
        }

        private void mbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void mbOK_Click(object sender, EventArgs e)
        {
            result = mtbInput.Text.ToUpper() ;
            this.DialogResult = DialogResult.OK;
            this.Visible = false;
        }

        private void MaterialInputBox_Shown(object sender, EventArgs e)
        {
            mtbInput.Focus();
        }
    }
}
