namespace AeroStat_Beta
{
    partial class TrafficLogForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "22-ASASAS",
            "",
            "tshoe33",
            "b33",
            "12 Oct 2020 22:22",
            "12 Oct 2020 22:22",
            "1",
            "2"}, -1);
            this.mlvFlightOrder = new MaterialSkin.Controls.MaterialListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.flightRule = new System.Windows.Forms.ColumnHeader();
            this.Callsign = new System.Windows.Forms.ColumnHeader();
            this.Number = new System.Windows.Forms.ColumnHeader();
            this.acType = new System.Windows.Forms.ColumnHeader();
            this.depPoint = new System.Windows.Forms.ColumnHeader();
            this.ETATA = new System.Windows.Forms.ColumnHeader();
            this.destination = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.mlvLocalStereoRequest = new MaterialSkin.Controls.MaterialListView();
            this.mbArr = new MaterialSkin.Controls.MaterialButton();
            this.mbDep = new MaterialSkin.Controls.MaterialButton();
            this.mbETA = new MaterialSkin.Controls.MaterialButton();
            this.mbCNL = new MaterialSkin.Controls.MaterialButton();
            this.mbCLR = new MaterialSkin.Controls.MaterialButton();
            this.mbRS = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mlvPPR = new MaterialSkin.Controls.MaterialListView();
            this.mlvStationed = new MaterialSkin.Controls.MaterialListView();
            this.ppr = new System.Windows.Forms.ColumnHeader("(none)");
            this.dv = new System.Windows.Forms.ColumnHeader();
            this.pprCallsign = new System.Windows.Forms.ColumnHeader();
            this.pprType = new System.Windows.Forms.ColumnHeader();
            this.arrDate = new System.Windows.Forms.ColumnHeader();
            this.depDate = new System.Windows.Forms.ColumnHeader();
            this.pprStatus = new System.Windows.Forms.ColumnHeader();
            this.pprSpot = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // mlvFlightOrder
            // 
            this.mlvFlightOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mlvFlightOrder.AutoSizeTable = false;
            this.mlvFlightOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvFlightOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvFlightOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.flightRule,
            this.Callsign,
            this.Number,
            this.acType,
            this.depPoint,
            this.ETATA,
            this.destination,
            this.status});
            this.mlvFlightOrder.Depth = 0;
            this.mlvFlightOrder.FullRowSelect = true;
            this.mlvFlightOrder.Location = new System.Drawing.Point(6, 333);
            this.mlvFlightOrder.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlvFlightOrder.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvFlightOrder.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvFlightOrder.MultiSelect = false;
            this.mlvFlightOrder.Name = "mlvFlightOrder";
            this.mlvFlightOrder.OwnerDraw = true;
            this.mlvFlightOrder.Size = new System.Drawing.Size(703, 418);
            this.mlvFlightOrder.TabIndex = 2;
            this.mlvFlightOrder.UseCompatibleStateImageBehavior = false;
            this.mlvFlightOrder.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Width = 0;
            // 
            // flightRule
            // 
            this.flightRule.Text = "Rule";
            // 
            // Callsign
            // 
            this.Callsign.Text = "Callsign";
            this.Callsign.Width = 120;
            // 
            // Number
            // 
            this.Number.Text = "#";
            this.Number.Width = 40;
            // 
            // acType
            // 
            this.acType.Text = "Type";
            this.acType.Width = 70;
            // 
            // depPoint
            // 
            this.depPoint.Text = "From";
            this.depPoint.Width = 70;
            // 
            // ETATA
            // 
            this.ETATA.Text = "ETA/ATA (Z)";
            this.ETATA.Width = 70;
            // 
            // destination
            // 
            this.destination.Text = "To";
            // 
            // status
            // 
            this.status.Text = "STS";
            this.status.Width = 100;
            // 
            // mlvLocalStereoRequest
            // 
            this.mlvLocalStereoRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mlvLocalStereoRequest.AutoSizeTable = false;
            this.mlvLocalStereoRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvLocalStereoRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvLocalStereoRequest.Depth = 0;
            this.mlvLocalStereoRequest.FullRowSelect = true;
            this.mlvLocalStereoRequest.Location = new System.Drawing.Point(913, 333);
            this.mlvLocalStereoRequest.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlvLocalStereoRequest.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvLocalStereoRequest.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvLocalStereoRequest.MultiSelect = false;
            this.mlvLocalStereoRequest.Name = "mlvLocalStereoRequest";
            this.mlvLocalStereoRequest.OwnerDraw = true;
            this.mlvLocalStereoRequest.Size = new System.Drawing.Size(703, 418);
            this.mlvLocalStereoRequest.TabIndex = 3;
            this.mlvLocalStereoRequest.UseCompatibleStateImageBehavior = false;
            this.mlvLocalStereoRequest.View = System.Windows.Forms.View.Details;
            // 
            // mbArr
            // 
            this.mbArr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbArr.AutoSize = false;
            this.mbArr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbArr.BackColor = System.Drawing.SystemColors.Control;
            this.mbArr.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbArr.Depth = 0;
            this.mbArr.HighEmphasis = true;
            this.mbArr.Icon = null;
            this.mbArr.Location = new System.Drawing.Point(781, 336);
            this.mbArr.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbArr.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbArr.Name = "mbArr";
            this.mbArr.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbArr.Size = new System.Drawing.Size(58, 24);
            this.mbArr.TabIndex = 4;
            this.mbArr.Tag = "arr";
            this.mbArr.Text = "ARR";
            this.mbArr.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbArr.UseAccentColor = false;
            this.mbArr.UseVisualStyleBackColor = false;
            // 
            // mbDep
            // 
            this.mbDep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbDep.AutoSize = false;
            this.mbDep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbDep.BackColor = System.Drawing.SystemColors.Control;
            this.mbDep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbDep.Depth = 0;
            this.mbDep.HighEmphasis = true;
            this.mbDep.Icon = null;
            this.mbDep.Location = new System.Drawing.Point(781, 372);
            this.mbDep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbDep.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbDep.Name = "mbDep";
            this.mbDep.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbDep.Size = new System.Drawing.Size(58, 24);
            this.mbDep.TabIndex = 5;
            this.mbDep.Tag = "dep";
            this.mbDep.Text = "DEP";
            this.mbDep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbDep.UseAccentColor = false;
            this.mbDep.UseVisualStyleBackColor = false;
            // 
            // mbETA
            // 
            this.mbETA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbETA.AutoSize = false;
            this.mbETA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbETA.BackColor = System.Drawing.SystemColors.Control;
            this.mbETA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbETA.Depth = 0;
            this.mbETA.HighEmphasis = true;
            this.mbETA.Icon = null;
            this.mbETA.Location = new System.Drawing.Point(781, 408);
            this.mbETA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbETA.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbETA.Name = "mbETA";
            this.mbETA.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbETA.Size = new System.Drawing.Size(58, 24);
            this.mbETA.TabIndex = 6;
            this.mbETA.Tag = "eta";
            this.mbETA.Text = "ETA";
            this.mbETA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbETA.UseAccentColor = false;
            this.mbETA.UseVisualStyleBackColor = false;
            // 
            // mbCNL
            // 
            this.mbCNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbCNL.AutoSize = false;
            this.mbCNL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbCNL.BackColor = System.Drawing.SystemColors.Control;
            this.mbCNL.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbCNL.Depth = 0;
            this.mbCNL.HighEmphasis = true;
            this.mbCNL.Icon = null;
            this.mbCNL.Location = new System.Drawing.Point(781, 444);
            this.mbCNL.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbCNL.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbCNL.Name = "mbCNL";
            this.mbCNL.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbCNL.Size = new System.Drawing.Size(58, 24);
            this.mbCNL.TabIndex = 7;
            this.mbCNL.Tag = "cnl";
            this.mbCNL.Text = "CNL";
            this.mbCNL.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbCNL.UseAccentColor = false;
            this.mbCNL.UseVisualStyleBackColor = false;
            // 
            // mbCLR
            // 
            this.mbCLR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbCLR.AutoSize = false;
            this.mbCLR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbCLR.BackColor = System.Drawing.SystemColors.Control;
            this.mbCLR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbCLR.Depth = 0;
            this.mbCLR.HighEmphasis = true;
            this.mbCLR.Icon = null;
            this.mbCLR.Location = new System.Drawing.Point(781, 480);
            this.mbCLR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbCLR.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbCLR.Name = "mbCLR";
            this.mbCLR.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbCLR.Size = new System.Drawing.Size(58, 24);
            this.mbCLR.TabIndex = 8;
            this.mbCLR.Tag = "clr";
            this.mbCLR.Text = "CLR";
            this.mbCLR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbCLR.UseAccentColor = false;
            this.mbCLR.UseVisualStyleBackColor = false;
            // 
            // mbRS
            // 
            this.mbRS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbRS.AutoSize = false;
            this.mbRS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbRS.BackColor = System.Drawing.SystemColors.Control;
            this.mbRS.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbRS.Depth = 0;
            this.mbRS.HighEmphasis = true;
            this.mbRS.Icon = null;
            this.mbRS.Location = new System.Drawing.Point(781, 516);
            this.mbRS.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbRS.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbRS.Name = "mbRS";
            this.mbRS.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbRS.Size = new System.Drawing.Size(58, 24);
            this.mbRS.TabIndex = 9;
            this.mbRS.Tag = "rs";
            this.mbRS.Text = "RS";
            this.mbRS.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbRS.UseAccentColor = false;
            this.mbRS.UseVisualStyleBackColor = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(6, 304);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1610, 23);
            this.materialDivider1.TabIndex = 10;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mlvPPR
            // 
            this.mlvPPR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mlvPPR.AutoSizeTable = false;
            this.mlvPPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvPPR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvPPR.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ppr,
            this.dv,
            this.pprCallsign,
            this.pprType,
            this.arrDate,
            this.depDate,
            this.pprStatus,
            this.pprSpot});
            this.mlvPPR.Depth = 0;
            this.mlvPPR.FullRowSelect = true;
            this.mlvPPR.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.mlvPPR.Location = new System.Drawing.Point(6, 67);
            this.mlvPPR.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlvPPR.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvPPR.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvPPR.MultiSelect = false;
            this.mlvPPR.Name = "mlvPPR";
            this.mlvPPR.OwnerDraw = true;
            this.mlvPPR.Size = new System.Drawing.Size(751, 231);
            this.mlvPPR.TabIndex = 11;
            this.mlvPPR.UseCompatibleStateImageBehavior = false;
            this.mlvPPR.View = System.Windows.Forms.View.Details;
            // 
            // mlvStationed
            // 
            this.mlvStationed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mlvStationed.AutoSizeTable = false;
            this.mlvStationed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvStationed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvStationed.Depth = 0;
            this.mlvStationed.FullRowSelect = true;
            this.mlvStationed.Location = new System.Drawing.Point(913, 67);
            this.mlvStationed.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlvStationed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvStationed.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvStationed.MultiSelect = false;
            this.mlvStationed.Name = "mlvStationed";
            this.mlvStationed.OwnerDraw = true;
            this.mlvStationed.Size = new System.Drawing.Size(703, 231);
            this.mlvStationed.TabIndex = 12;
            this.mlvStationed.UseCompatibleStateImageBehavior = false;
            this.mlvStationed.View = System.Windows.Forms.View.Details;
            // 
            // ppr
            // 
            this.ppr.Text = "PPR";
            this.ppr.Width = 80;
            // 
            // dv
            // 
            this.dv.Text = "DV";
            this.dv.Width = 49;
            // 
            // pprCallsign
            // 
            this.pprCallsign.Text = "Callsign";
            this.pprCallsign.Width = 90;
            // 
            // pprType
            // 
            this.pprType.Text = "Type";
            this.pprType.Width = 70;
            // 
            // arrDate
            // 
            this.arrDate.Text = "Arrival Date (L)";
            this.arrDate.Width = 150;
            // 
            // depDate
            // 
            this.depDate.Text = "Departure Date (L)";
            this.depDate.Width = 150;
            // 
            // pprStatus
            // 
            this.pprStatus.Text = "Status";
            this.pprStatus.Width = 100;
            // 
            // pprSpot
            // 
            this.pprSpot.Text = "Spot";
            // 
            // TrafficLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 765);
            this.Controls.Add(this.mlvStationed);
            this.Controls.Add(this.mlvPPR);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.mbRS);
            this.Controls.Add(this.mbCLR);
            this.Controls.Add(this.mbCNL);
            this.Controls.Add(this.mbETA);
            this.Controls.Add(this.mbDep);
            this.Controls.Add(this.mbArr);
            this.Controls.Add(this.mlvLocalStereoRequest);
            this.Controls.Add(this.mlvFlightOrder);
            this.MinimumSize = new System.Drawing.Size(1622, 765);
            this.Name = "TrafficLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Traffic Log";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTrafficLog_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialListView mlvFlightOrder;
        private ColumnHeader ID;
        private ColumnHeader flightRule;
        private ColumnHeader Callsign;
        private ColumnHeader Number;
        private ColumnHeader acType;
        private ColumnHeader depPoint;
        private ColumnHeader ETATA;
        private ColumnHeader status;
        private MaterialSkin.Controls.MaterialListView mlvLocalStereoRequest;
        private MaterialSkin.Controls.MaterialButton mbArr;
        private MaterialSkin.Controls.MaterialButton mbDep;
        private MaterialSkin.Controls.MaterialButton mbETA;
        private MaterialSkin.Controls.MaterialButton mbCNL;
        private MaterialSkin.Controls.MaterialButton mbCLR;
        private MaterialSkin.Controls.MaterialButton mbRS;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private ColumnHeader destination;
        private MaterialSkin.Controls.MaterialListView mlvPPR;
        private MaterialSkin.Controls.MaterialListView mlvStationed;
        private ColumnHeader ppr;
        private ColumnHeader dv;
        private ColumnHeader pprCallsign;
        private ColumnHeader pprType;
        private ColumnHeader arrDate;
        private ColumnHeader depDate;
        private ColumnHeader pprStatus;
        private ColumnHeader pprSpot;
    }
}