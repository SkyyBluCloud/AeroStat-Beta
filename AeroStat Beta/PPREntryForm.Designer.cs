namespace AeroStat_Beta
{
    partial class PPREntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            MaterialSkin.MaterialListBoxItem materialListBoxItem3 = new MaterialSkin.MaterialListBoxItem();
            this.mxpPOCInfo = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.mtbContactInfo = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbPOCName = new MaterialSkin.Controls.MaterialTextBox();
            this.mxpServices = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.mlbServices = new MaterialSkin.Controls.MaterialListBox();
            this.mtbNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.bsPPR = new System.Windows.Forms.BindingSource(this.components);
            this.mtbDepDate = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbDestination = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbArrDate = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbDepPoint = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbTail = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbType = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbCallsign = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbFuel = new MaterialSkin.Controls.MaterialTextBox();
            this.mcbSpot = new MaterialSkin.Controls.MaterialComboBox();
            this.mtbDVCode = new MaterialSkin.Controls.MaterialComboBox();
            this.mbSave = new MaterialSkin.Controls.MaterialButton();
            this.mbCancel = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mxpPPR = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.mtbMSN = new MaterialSkin.Controls.MaterialTextBox();
            this.mrbManualPPR = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbAutoPPR = new MaterialSkin.Controls.MaterialRadioButton();
            this.mtbPPR = new MaterialSkin.Controls.MaterialTextBox();
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.mxpPOCInfo.SuspendLayout();
            this.mxpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPPR)).BeginInit();
            this.mxpPPR.SuspendLayout();
            this.SuspendLayout();
            // 
            // mxpPOCInfo
            // 
            this.mxpPOCInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mxpPOCInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mxpPOCInfo.CancelButtonText = "";
            this.mxpPOCInfo.Collapse = true;
            this.mxpPOCInfo.Controls.Add(this.mtbContactInfo);
            this.mxpPOCInfo.Controls.Add(this.mtbUnit);
            this.mxpPOCInfo.Controls.Add(this.mtbPOCName);
            this.mxpPOCInfo.Depth = 0;
            this.mxpPOCInfo.Description = "";
            this.mxpPOCInfo.ExpandHeight = 286;
            this.mxpPOCInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mxpPOCInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mxpPOCInfo.Location = new System.Drawing.Point(394, 282);
            this.mxpPOCInfo.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.mxpPOCInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mxpPOCInfo.Name = "mxpPOCInfo";
            this.mxpPOCInfo.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mxpPOCInfo.Size = new System.Drawing.Size(339, 48);
            this.mxpPOCInfo.TabIndex = 10;
            this.mxpPOCInfo.Title = "POC Information";
            this.mxpPOCInfo.ValidationButtonEnable = true;
            this.mxpPOCInfo.ValidationButtonText = "Apply";
            // 
            // mtbContactInfo
            // 
            this.mtbContactInfo.AnimateReadOnly = false;
            this.mtbContactInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbContactInfo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "ctcInfo", true));
            this.mtbContactInfo.Depth = 0;
            this.mtbContactInfo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbContactInfo.Hint = "Contact Info";
            this.mtbContactInfo.LeadingIcon = null;
            this.mtbContactInfo.Location = new System.Drawing.Point(27, 163);
            this.mtbContactInfo.MaxLength = 50;
            this.mtbContactInfo.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbContactInfo.Multiline = false;
            this.mtbContactInfo.Name = "mtbContactInfo";
            this.mtbContactInfo.Size = new System.Drawing.Size(206, 50);
            this.mtbContactInfo.TabIndex = 4;
            this.mtbContactInfo.Text = "";
            this.mtbContactInfo.TrailingIcon = null;
            // 
            // mtbUnit
            // 
            this.mtbUnit.AnimateReadOnly = false;
            this.mtbUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "unit", true));
            this.mtbUnit.Depth = 0;
            this.mtbUnit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbUnit.Hint = "Unit";
            this.mtbUnit.LeadingIcon = null;
            this.mtbUnit.Location = new System.Drawing.Point(27, 107);
            this.mtbUnit.MaxLength = 50;
            this.mtbUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbUnit.Multiline = false;
            this.mtbUnit.Name = "mtbUnit";
            this.mtbUnit.Size = new System.Drawing.Size(206, 50);
            this.mtbUnit.TabIndex = 3;
            this.mtbUnit.Text = "";
            this.mtbUnit.TrailingIcon = null;
            // 
            // mtbPOCName
            // 
            this.mtbPOCName.AnimateReadOnly = false;
            this.mtbPOCName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbPOCName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "pocName", true));
            this.mtbPOCName.Depth = 0;
            this.mtbPOCName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbPOCName.Hint = "Name";
            this.mtbPOCName.LeadingIcon = null;
            this.mtbPOCName.Location = new System.Drawing.Point(27, 51);
            this.mtbPOCName.MaxLength = 50;
            this.mtbPOCName.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbPOCName.Multiline = false;
            this.mtbPOCName.Name = "mtbPOCName";
            this.mtbPOCName.Size = new System.Drawing.Size(206, 50);
            this.mtbPOCName.TabIndex = 2;
            this.mtbPOCName.Text = "";
            this.mtbPOCName.TrailingIcon = null;
            // 
            // mxpServices
            // 
            this.mxpServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mxpServices.CancelButtonText = "";
            this.mxpServices.Collapse = true;
            this.mxpServices.Controls.Add(this.mlbServices);
            this.mxpServices.Depth = 0;
            this.mxpServices.Description = "";
            this.mxpServices.ExpandHeight = 286;
            this.mxpServices.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mxpServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mxpServices.Location = new System.Drawing.Point(19, 282);
            this.mxpServices.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.mxpServices.MouseState = MaterialSkin.MouseState.HOVER;
            this.mxpServices.Name = "mxpServices";
            this.mxpServices.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mxpServices.Size = new System.Drawing.Size(369, 48);
            this.mxpServices.TabIndex = 11;
            this.mxpServices.Title = "Services";
            this.mxpServices.ValidationButtonEnable = true;
            this.mxpServices.ValidationButtonText = "Apply";
            // 
            // mlbServices
            // 
            this.mlbServices.BackColor = System.Drawing.Color.White;
            this.mlbServices.BorderColor = System.Drawing.Color.LightGray;
            this.mlbServices.Depth = 0;
            this.mlbServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlbServices.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialListBoxItem3.SecondaryText = "";
            materialListBoxItem3.Tag = null;
            materialListBoxItem3.Text = "ListBoxItem";
            this.mlbServices.Items.Add(materialListBoxItem3);
            this.mlbServices.Location = new System.Drawing.Point(24, 64);
            this.mlbServices.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlbServices.MultiSelect = true;
            this.mlbServices.Name = "mlbServices";
            this.mlbServices.SelectedIndex = -1;
            this.mlbServices.SelectedItem = null;
            this.mlbServices.Size = new System.Drawing.Size(321, 147);
            this.mlbServices.TabIndex = 2;
            this.mlbServices.TabStop = false;
            // 
            // mtbNumber
            // 
            this.mtbNumber.AnimateReadOnly = false;
            this.mtbNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "number", true));
            this.mtbNumber.Depth = 0;
            this.mtbNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbNumber.Hint = "#";
            this.mtbNumber.LeadingIcon = null;
            this.mtbNumber.Location = new System.Drawing.Point(231, 116);
            this.mtbNumber.MaxLength = 50;
            this.mtbNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbNumber.Multiline = false;
            this.mtbNumber.Name = "mtbNumber";
            this.mtbNumber.Size = new System.Drawing.Size(51, 50);
            this.mtbNumber.TabIndex = 25;
            this.mtbNumber.Text = "";
            this.mtbNumber.TrailingIcon = null;
            // 
            // bsPPR
            // 
            this.bsPPR.AllowNew = true;
            this.bsPPR.DataSource = typeof(AeroStat_Beta.PPR);
            // 
            // mtbDepDate
            // 
            this.mtbDepDate.AnimateReadOnly = false;
            this.mtbDepDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbDepDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "depDate", true));
            this.mtbDepDate.Depth = 0;
            this.mtbDepDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbDepDate.Hint = "Departure Date";
            this.mtbDepDate.LeadingIcon = null;
            this.mtbDepDate.Location = new System.Drawing.Point(125, 228);
            this.mtbDepDate.MaxLength = 50;
            this.mtbDepDate.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbDepDate.Multiline = false;
            this.mtbDepDate.Name = "mtbDepDate";
            this.mtbDepDate.Size = new System.Drawing.Size(263, 50);
            this.mtbDepDate.TabIndex = 24;
            this.mtbDepDate.Text = "";
            this.mtbDepDate.TrailingIcon = null;
            // 
            // mtbDestination
            // 
            this.mtbDestination.AnimateReadOnly = false;
            this.mtbDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbDestination.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "destination", true));
            this.mtbDestination.Depth = 0;
            this.mtbDestination.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbDestination.Hint = "To";
            this.mtbDestination.LeadingIcon = null;
            this.mtbDestination.Location = new System.Drawing.Point(19, 228);
            this.mtbDestination.MaxLength = 50;
            this.mtbDestination.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbDestination.Multiline = false;
            this.mtbDestination.Name = "mtbDestination";
            this.mtbDestination.Size = new System.Drawing.Size(100, 50);
            this.mtbDestination.TabIndex = 23;
            this.mtbDestination.Text = "";
            this.mtbDestination.TrailingIcon = null;
            // 
            // mtbArrDate
            // 
            this.mtbArrDate.AnimateReadOnly = false;
            this.mtbArrDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbArrDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "arrDate", true));
            this.mtbArrDate.Depth = 0;
            this.mtbArrDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbArrDate.Hint = "Arrival Date";
            this.mtbArrDate.LeadingIcon = null;
            this.mtbArrDate.Location = new System.Drawing.Point(125, 172);
            this.mtbArrDate.MaxLength = 50;
            this.mtbArrDate.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbArrDate.Multiline = false;
            this.mtbArrDate.Name = "mtbArrDate";
            this.mtbArrDate.Size = new System.Drawing.Size(263, 50);
            this.mtbArrDate.TabIndex = 22;
            this.mtbArrDate.Text = "";
            this.mtbArrDate.TrailingIcon = null;
            // 
            // mtbDepPoint
            // 
            this.mtbDepPoint.AnimateReadOnly = false;
            this.mtbDepPoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbDepPoint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "depPoint", true));
            this.mtbDepPoint.Depth = 0;
            this.mtbDepPoint.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbDepPoint.Hint = "From";
            this.mtbDepPoint.LeadingIcon = null;
            this.mtbDepPoint.Location = new System.Drawing.Point(19, 172);
            this.mtbDepPoint.MaxLength = 50;
            this.mtbDepPoint.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbDepPoint.Multiline = false;
            this.mtbDepPoint.Name = "mtbDepPoint";
            this.mtbDepPoint.Size = new System.Drawing.Size(100, 50);
            this.mtbDepPoint.TabIndex = 21;
            this.mtbDepPoint.Text = "";
            this.mtbDepPoint.TrailingIcon = null;
            // 
            // mtbTail
            // 
            this.mtbTail.AnimateReadOnly = false;
            this.mtbTail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbTail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "tail", true));
            this.mtbTail.Depth = 0;
            this.mtbTail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbTail.Hint = "Tail/Reg";
            this.mtbTail.LeadingIcon = null;
            this.mtbTail.Location = new System.Drawing.Point(394, 116);
            this.mtbTail.MaxLength = 50;
            this.mtbTail.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbTail.Multiline = false;
            this.mtbTail.Name = "mtbTail";
            this.mtbTail.Size = new System.Drawing.Size(227, 50);
            this.mtbTail.TabIndex = 20;
            this.mtbTail.Text = "";
            this.mtbTail.TrailingIcon = null;
            // 
            // mtbType
            // 
            this.mtbType.AnimateReadOnly = false;
            this.mtbType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "type", true));
            this.mtbType.Depth = 0;
            this.mtbType.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbType.Hint = "Type";
            this.mtbType.LeadingIcon = null;
            this.mtbType.Location = new System.Drawing.Point(288, 116);
            this.mtbType.MaxLength = 50;
            this.mtbType.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbType.Multiline = false;
            this.mtbType.Name = "mtbType";
            this.mtbType.Size = new System.Drawing.Size(100, 50);
            this.mtbType.TabIndex = 19;
            this.mtbType.Text = "";
            this.mtbType.TrailingIcon = null;
            // 
            // mtbCallsign
            // 
            this.mtbCallsign.AnimateReadOnly = false;
            this.mtbCallsign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbCallsign.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "callsign", true));
            this.mtbCallsign.Depth = 0;
            this.mtbCallsign.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbCallsign.Hint = "Callsign";
            this.mtbCallsign.LeadingIcon = null;
            this.mtbCallsign.Location = new System.Drawing.Point(19, 116);
            this.mtbCallsign.MaxLength = 50;
            this.mtbCallsign.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbCallsign.Multiline = false;
            this.mtbCallsign.Name = "mtbCallsign";
            this.mtbCallsign.Size = new System.Drawing.Size(206, 50);
            this.mtbCallsign.TabIndex = 18;
            this.mtbCallsign.Text = "";
            this.mtbCallsign.TrailingIcon = null;
            // 
            // mtbFuel
            // 
            this.mtbFuel.AnimateReadOnly = false;
            this.mtbFuel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbFuel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "fuel", true));
            this.mtbFuel.Depth = 0;
            this.mtbFuel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbFuel.Hint = "Fuel";
            this.mtbFuel.LeadingIcon = null;
            this.mtbFuel.Location = new System.Drawing.Point(521, 172);
            this.mtbFuel.MaxLength = 50;
            this.mtbFuel.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbFuel.Multiline = false;
            this.mtbFuel.Name = "mtbFuel";
            this.mtbFuel.Size = new System.Drawing.Size(100, 50);
            this.mtbFuel.TabIndex = 28;
            this.mtbFuel.Text = "";
            this.mtbFuel.TrailingIcon = null;
            // 
            // mcbSpot
            // 
            this.mcbSpot.AutoResize = false;
            this.mcbSpot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcbSpot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "spot", true));
            this.mcbSpot.Depth = 0;
            this.mcbSpot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcbSpot.DropDownHeight = 174;
            this.mcbSpot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcbSpot.DropDownWidth = 121;
            this.mcbSpot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcbSpot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcbSpot.FormattingEnabled = true;
            this.mcbSpot.Hint = "Spot";
            this.mcbSpot.IntegralHeight = false;
            this.mcbSpot.ItemHeight = 43;
            this.mcbSpot.Location = new System.Drawing.Point(394, 172);
            this.mcbSpot.MaxDropDownItems = 4;
            this.mcbSpot.MouseState = MaterialSkin.MouseState.OUT;
            this.mcbSpot.Name = "mcbSpot";
            this.mcbSpot.Size = new System.Drawing.Size(121, 49);
            this.mcbSpot.StartIndex = 0;
            this.mcbSpot.TabIndex = 29;
            // 
            // mtbDVCode
            // 
            this.mtbDVCode.AutoResize = false;
            this.mtbDVCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtbDVCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "dvCode", true));
            this.mtbDVCode.Depth = 0;
            this.mtbDVCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mtbDVCode.DropDownHeight = 174;
            this.mtbDVCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mtbDVCode.DropDownWidth = 121;
            this.mtbDVCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mtbDVCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtbDVCode.FormattingEnabled = true;
            this.mtbDVCode.Hint = "DV Code";
            this.mtbDVCode.IntegralHeight = false;
            this.mtbDVCode.ItemHeight = 43;
            this.mtbDVCode.Location = new System.Drawing.Point(394, 228);
            this.mtbDVCode.MaxDropDownItems = 4;
            this.mtbDVCode.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbDVCode.Name = "mtbDVCode";
            this.mtbDVCode.Size = new System.Drawing.Size(121, 49);
            this.mtbDVCode.StartIndex = 0;
            this.mtbDVCode.TabIndex = 30;
            // 
            // mbSave
            // 
            this.mbSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbSave.Depth = 0;
            this.mbSave.HighEmphasis = true;
            this.mbSave.Icon = null;
            this.mbSave.Location = new System.Drawing.Point(661, 363);
            this.mbSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbSave.Name = "mbSave";
            this.mbSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbSave.Size = new System.Drawing.Size(84, 36);
            this.mbSave.TabIndex = 31;
            this.mbSave.Text = "&Submit";
            this.mbSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbSave.UseAccentColor = false;
            this.mbSave.UseVisualStyleBackColor = true;
            // 
            // mbCancel
            // 
            this.mbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbCancel.Depth = 0;
            this.mbCancel.HighEmphasis = true;
            this.mbCancel.Icon = null;
            this.mbCancel.Location = new System.Drawing.Point(566, 363);
            this.mbCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbCancel.Size = new System.Drawing.Size(87, 36);
            this.mbCancel.TabIndex = 32;
            this.mbCancel.Text = "&Cancel";
            this.mbCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbCancel.UseAccentColor = false;
            this.mbCancel.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(6, 333);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(740, 21);
            this.materialDivider1.TabIndex = 33;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mxpPPR
            // 
            this.mxpPPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mxpPPR.CancelButtonText = "";
            this.mxpPPR.Collapse = true;
            this.mxpPPR.Controls.Add(this.mtbMSN);
            this.mxpPPR.Controls.Add(this.mrbManualPPR);
            this.mxpPPR.Controls.Add(this.mrbAutoPPR);
            this.mxpPPR.Controls.Add(this.mtbPPR);
            this.mxpPPR.Depth = 0;
            this.mxpPPR.ExpandHeight = 334;
            this.mxpPPR.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mxpPPR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mxpPPR.Location = new System.Drawing.Point(19, 65);
            this.mxpPPR.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.mxpPPR.MouseState = MaterialSkin.MouseState.HOVER;
            this.mxpPPR.Name = "mxpPPR";
            this.mxpPPR.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.mxpPPR.Size = new System.Drawing.Size(369, 48);
            this.mxpPPR.TabIndex = 34;
            this.mxpPPR.Title = "PPR:";
            this.mxpPPR.ValidationButtonEnable = true;
            this.mxpPPR.ValidationButtonText = "Apply";
            // 
            // mtbMSN
            // 
            this.mtbMSN.AnimateReadOnly = false;
            this.mtbMSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbMSN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "msn", true));
            this.mtbMSN.Depth = 0;
            this.mtbMSN.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbMSN.Hint = "MSN #";
            this.mtbMSN.LeadingIcon = null;
            this.mtbMSN.Location = new System.Drawing.Point(27, 123);
            this.mtbMSN.MaxLength = 50;
            this.mtbMSN.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbMSN.Multiline = false;
            this.mtbMSN.Name = "mtbMSN";
            this.mtbMSN.Size = new System.Drawing.Size(236, 50);
            this.mtbMSN.TabIndex = 38;
            this.mtbMSN.Text = "";
            this.mtbMSN.TrailingIcon = null;
            // 
            // mrbManualPPR
            // 
            this.mrbManualPPR.AutoSize = true;
            this.mrbManualPPR.Depth = 0;
            this.mrbManualPPR.Location = new System.Drawing.Point(24, 228);
            this.mrbManualPPR.Margin = new System.Windows.Forms.Padding(0);
            this.mrbManualPPR.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbManualPPR.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbManualPPR.Name = "mrbManualPPR";
            this.mrbManualPPR.Ripple = true;
            this.mrbManualPPR.Size = new System.Drawing.Size(123, 37);
            this.mrbManualPPR.TabIndex = 37;
            this.mrbManualPPR.TabStop = true;
            this.mrbManualPPR.Text = "Manual PPR";
            this.mrbManualPPR.UseVisualStyleBackColor = true;
            // 
            // mrbAutoPPR
            // 
            this.mrbAutoPPR.AutoSize = true;
            this.mrbAutoPPR.Depth = 0;
            this.mrbAutoPPR.Location = new System.Drawing.Point(24, 191);
            this.mrbAutoPPR.Margin = new System.Windows.Forms.Padding(0);
            this.mrbAutoPPR.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbAutoPPR.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbAutoPPR.Name = "mrbAutoPPR";
            this.mrbAutoPPR.Ripple = true;
            this.mrbAutoPPR.Size = new System.Drawing.Size(167, 37);
            this.mrbAutoPPR.TabIndex = 36;
            this.mrbAutoPPR.TabStop = true;
            this.mrbAutoPPR.Text = "Auto-generate PPR";
            this.mrbAutoPPR.UseVisualStyleBackColor = true;
            // 
            // mtbPPR
            // 
            this.mtbPPR.AnimateReadOnly = false;
            this.mtbPPR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbPPR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPPR, "pprNumber", true));
            this.mtbPPR.Depth = 0;
            this.mtbPPR.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbPPR.Hint = "PPR #";
            this.mtbPPR.LeadingIcon = null;
            this.mtbPPR.Location = new System.Drawing.Point(27, 67);
            this.mtbPPR.MaxLength = 50;
            this.mtbPPR.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbPPR.Multiline = false;
            this.mtbPPR.Name = "mtbPPR";
            this.mtbPPR.Size = new System.Drawing.Size(236, 50);
            this.mtbPPR.TabIndex = 35;
            this.mtbPPR.Text = "";
            this.mtbPPR.TrailingIcon = null;
            // 
            // materialListView2
            // 
            this.materialListView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView2.AutoSizeTable = false;
            this.materialListView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView2.Depth = 0;
            this.materialListView2.FullRowSelect = true;
            this.materialListView2.Location = new System.Drawing.Point(6, 408);
            this.materialListView2.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView2.Name = "materialListView2";
            this.materialListView2.OwnerDraw = true;
            this.materialListView2.Size = new System.Drawing.Size(740, 160);
            this.materialListView2.TabIndex = 35;
            this.materialListView2.UseCompatibleStateImageBehavior = false;
            this.materialListView2.View = System.Windows.Forms.View.Details;
            this.materialListView2.Visible = false;
            // 
            // PPREntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(752, 574);
            this.Controls.Add(this.mxpPPR);
            this.Controls.Add(this.mxpPOCInfo);
            this.Controls.Add(this.mxpServices);
            this.Controls.Add(this.materialListView2);
            this.Controls.Add(this.mtbDVCode);
            this.Controls.Add(this.mcbSpot);
            this.Controls.Add(this.mtbFuel);
            this.Controls.Add(this.mtbNumber);
            this.Controls.Add(this.mtbDepDate);
            this.Controls.Add(this.mtbDestination);
            this.Controls.Add(this.mtbArrDate);
            this.Controls.Add(this.mtbDepPoint);
            this.Controls.Add(this.mtbTail);
            this.Controls.Add(this.mtbType);
            this.Controls.Add(this.mtbCallsign);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.mbSave);
            this.Controls.Add(this.mbCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(752, 446);
            this.Name = "PPREntryForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPR Request";
            this.TopMost = true;
            this.mxpPOCInfo.ResumeLayout(false);
            this.mxpPOCInfo.PerformLayout();
            this.mxpServices.ResumeLayout(false);
            this.mxpServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPPR)).EndInit();
            this.mxpPPR.ResumeLayout(false);
            this.mxpPPR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialExpansionPanel mxpPOCInfo;
        private MaterialSkin.Controls.MaterialTextBox mtbContactInfo;
        private MaterialSkin.Controls.MaterialTextBox mtbUnit;
        private MaterialSkin.Controls.MaterialTextBox mtbPOCName;
        private MaterialSkin.Controls.MaterialExpansionPanel mxpServices;
        private MaterialSkin.Controls.MaterialTextBox mtbNumber;
        private MaterialSkin.Controls.MaterialTextBox mtbDepDate;
        private MaterialSkin.Controls.MaterialTextBox mtbDestination;
        private MaterialSkin.Controls.MaterialTextBox mtbArrDate;
        private MaterialSkin.Controls.MaterialTextBox mtbDepPoint;
        private MaterialSkin.Controls.MaterialTextBox mtbTail;
        private MaterialSkin.Controls.MaterialTextBox mtbType;
        private MaterialSkin.Controls.MaterialTextBox mtbCallsign;
        private MaterialSkin.Controls.MaterialTextBox mtbFuel;
        private MaterialSkin.Controls.MaterialComboBox mcbSpot;
        private MaterialSkin.Controls.MaterialListBox mlbServices;
        private MaterialSkin.Controls.MaterialComboBox mtbDVCode;
        private MaterialSkin.Controls.MaterialButton mbSave;
        private MaterialSkin.Controls.MaterialButton mbCancel;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialExpansionPanel mxpPPR;
        private MaterialSkin.Controls.MaterialTextBox mtbMSN;
        private MaterialSkin.Controls.MaterialRadioButton mrbManualPPR;
        private MaterialSkin.Controls.MaterialRadioButton mrbAutoPPR;
        private MaterialSkin.Controls.MaterialTextBox mtbPPR;
        private MaterialSkin.Controls.MaterialListView materialListView2;
        private BindingSource bsPPR;
    }
}