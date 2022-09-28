namespace AeroStat_Beta
{
    partial class frmTrafficLog
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.flightRule = new System.Windows.Forms.ColumnHeader();
            this.Callsign = new System.Windows.Forms.ColumnHeader();
            this.Type = new System.Windows.Forms.ColumnHeader();
            this.depPoint = new System.Windows.Forms.ColumnHeader();
            this.eata = new System.Windows.Forms.ColumnHeader();
            this.sts = new System.Windows.Forms.ColumnHeader();
            this.eatd = new System.Windows.Forms.ColumnHeader();
            this.ete = new System.Windows.Forms.ColumnHeader();
            this.dof = new System.Windows.Forms.ColumnHeader();
            this.ceta = new System.Windows.Forms.ColumnHeader();
            this.destination = new System.Windows.Forms.ColumnHeader();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trafficBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certifierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callsignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightRuleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fpTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dofDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rwyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.flightRule,
            this.Callsign,
            this.Type,
            this.depPoint,
            this.eata,
            this.sts,
            this.eatd,
            this.ete,
            this.dof,
            this.ceta,
            this.destination});
            this.listView1.Location = new System.Drawing.Point(62, 283);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(539, 252);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Width = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryDateDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.certifierIDDataGridViewTextBoxColumn,
            this.pprDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.callsignDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.acTypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.flightRuleDataGridViewTextBoxColumn,
            this.depPointDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.fpTypeDataGridViewTextBoxColumn,
            this.dofDataGridViewTextBoxColumn,
            this.etdDataGridViewTextBoxColumn,
            this.eteDataGridViewTextBoxColumn,
            this.etaDataGridViewTextBoxColumn,
            this.atdDataGridViewTextBoxColumn,
            this.ataDataGridViewTextBoxColumn,
            this.spotDataGridViewTextBoxColumn,
            this.altitudeDataGridViewTextBoxColumn,
            this.tailDataGridViewTextBoxColumn,
            this.rwyDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trafficBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(539, 195);
            this.dataGridView1.TabIndex = 1;
            // 
            // trafficBindingSource
            // 
            this.trafficBindingSource.DataSource = typeof(AeroStat_Beta.Traffic);
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "entryDate";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "entryDate";
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "shift";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // certifierIDDataGridViewTextBoxColumn
            // 
            this.certifierIDDataGridViewTextBoxColumn.DataPropertyName = "certifierID";
            this.certifierIDDataGridViewTextBoxColumn.HeaderText = "certifierID";
            this.certifierIDDataGridViewTextBoxColumn.Name = "certifierIDDataGridViewTextBoxColumn";
            // 
            // pprDataGridViewTextBoxColumn
            // 
            this.pprDataGridViewTextBoxColumn.DataPropertyName = "ppr";
            this.pprDataGridViewTextBoxColumn.HeaderText = "ppr";
            this.pprDataGridViewTextBoxColumn.Name = "pprDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
            this.userDataGridViewTextBoxColumn.HeaderText = "user";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // callsignDataGridViewTextBoxColumn
            // 
            this.callsignDataGridViewTextBoxColumn.DataPropertyName = "callsign";
            this.callsignDataGridViewTextBoxColumn.HeaderText = "callsign";
            this.callsignDataGridViewTextBoxColumn.Name = "callsignDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // acTypeDataGridViewTextBoxColumn
            // 
            this.acTypeDataGridViewTextBoxColumn.DataPropertyName = "acType";
            this.acTypeDataGridViewTextBoxColumn.HeaderText = "acType";
            this.acTypeDataGridViewTextBoxColumn.Name = "acTypeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // flightRuleDataGridViewTextBoxColumn
            // 
            this.flightRuleDataGridViewTextBoxColumn.DataPropertyName = "flightRule";
            this.flightRuleDataGridViewTextBoxColumn.HeaderText = "flightRule";
            this.flightRuleDataGridViewTextBoxColumn.Name = "flightRuleDataGridViewTextBoxColumn";
            // 
            // depPointDataGridViewTextBoxColumn
            // 
            this.depPointDataGridViewTextBoxColumn.DataPropertyName = "depPoint";
            this.depPointDataGridViewTextBoxColumn.HeaderText = "depPoint";
            this.depPointDataGridViewTextBoxColumn.Name = "depPointDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // fpTypeDataGridViewTextBoxColumn
            // 
            this.fpTypeDataGridViewTextBoxColumn.DataPropertyName = "fpType";
            this.fpTypeDataGridViewTextBoxColumn.HeaderText = "fpType";
            this.fpTypeDataGridViewTextBoxColumn.Name = "fpTypeDataGridViewTextBoxColumn";
            // 
            // dofDataGridViewTextBoxColumn
            // 
            this.dofDataGridViewTextBoxColumn.DataPropertyName = "dof";
            this.dofDataGridViewTextBoxColumn.HeaderText = "dof";
            this.dofDataGridViewTextBoxColumn.Name = "dofDataGridViewTextBoxColumn";
            // 
            // etdDataGridViewTextBoxColumn
            // 
            this.etdDataGridViewTextBoxColumn.DataPropertyName = "etd";
            this.etdDataGridViewTextBoxColumn.HeaderText = "etd";
            this.etdDataGridViewTextBoxColumn.Name = "etdDataGridViewTextBoxColumn";
            // 
            // eteDataGridViewTextBoxColumn
            // 
            this.eteDataGridViewTextBoxColumn.DataPropertyName = "ete";
            this.eteDataGridViewTextBoxColumn.HeaderText = "ete";
            this.eteDataGridViewTextBoxColumn.Name = "eteDataGridViewTextBoxColumn";
            // 
            // etaDataGridViewTextBoxColumn
            // 
            this.etaDataGridViewTextBoxColumn.DataPropertyName = "eta";
            this.etaDataGridViewTextBoxColumn.HeaderText = "eta";
            this.etaDataGridViewTextBoxColumn.Name = "etaDataGridViewTextBoxColumn";
            // 
            // atdDataGridViewTextBoxColumn
            // 
            this.atdDataGridViewTextBoxColumn.DataPropertyName = "atd";
            this.atdDataGridViewTextBoxColumn.HeaderText = "atd";
            this.atdDataGridViewTextBoxColumn.Name = "atdDataGridViewTextBoxColumn";
            // 
            // ataDataGridViewTextBoxColumn
            // 
            this.ataDataGridViewTextBoxColumn.DataPropertyName = "ata";
            this.ataDataGridViewTextBoxColumn.HeaderText = "ata";
            this.ataDataGridViewTextBoxColumn.Name = "ataDataGridViewTextBoxColumn";
            // 
            // spotDataGridViewTextBoxColumn
            // 
            this.spotDataGridViewTextBoxColumn.DataPropertyName = "spot";
            this.spotDataGridViewTextBoxColumn.HeaderText = "spot";
            this.spotDataGridViewTextBoxColumn.Name = "spotDataGridViewTextBoxColumn";
            // 
            // altitudeDataGridViewTextBoxColumn
            // 
            this.altitudeDataGridViewTextBoxColumn.DataPropertyName = "altitude";
            this.altitudeDataGridViewTextBoxColumn.HeaderText = "altitude";
            this.altitudeDataGridViewTextBoxColumn.Name = "altitudeDataGridViewTextBoxColumn";
            // 
            // tailDataGridViewTextBoxColumn
            // 
            this.tailDataGridViewTextBoxColumn.DataPropertyName = "tail";
            this.tailDataGridViewTextBoxColumn.HeaderText = "tail";
            this.tailDataGridViewTextBoxColumn.Name = "tailDataGridViewTextBoxColumn";
            // 
            // rwyDataGridViewTextBoxColumn
            // 
            this.rwyDataGridViewTextBoxColumn.DataPropertyName = "rwy";
            this.rwyDataGridViewTextBoxColumn.HeaderText = "rwy";
            this.rwyDataGridViewTextBoxColumn.Name = "rwyDataGridViewTextBoxColumn";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // frmTrafficLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 592);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Name = "frmTrafficLog";
            this.Text = "frmTrafficLog";
            this.Load += new System.EventHandler(this.frmTrafficLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader flightRule;
        private ColumnHeader Callsign;
        private ColumnHeader Type;
        private ColumnHeader depPoint;
        private ColumnHeader eata;
        private ColumnHeader sts;
        private ColumnHeader eatd;
        private ColumnHeader ete;
        private ColumnHeader dof;
        private ColumnHeader ceta;
        private ColumnHeader destination;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn certifierIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pprDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn callsignDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn flightRuleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn depPointDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fpTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dofDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn etdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn etaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn atdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn spotDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn altitudeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rwyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private BindingSource trafficBindingSource;
    }
}