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
            this.lstPPR = new System.Windows.Forms.ListBox();
            this.lstArrivals = new System.Windows.Forms.ListBox();
            this.lstOnStation = new System.Windows.Forms.ListBox();
            this.lstDepartures = new System.Windows.Forms.ListBox();
            this.lstLocal = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstPPR
            // 
            this.lstPPR.FormattingEnabled = true;
            this.lstPPR.ItemHeight = 15;
            this.lstPPR.Location = new System.Drawing.Point(74, 79);
            this.lstPPR.Name = "lstPPR";
            this.lstPPR.Size = new System.Drawing.Size(502, 214);
            this.lstPPR.TabIndex = 0;
            // 
            // lstArrivals
            // 
            this.lstArrivals.FormattingEnabled = true;
            this.lstArrivals.ItemHeight = 15;
            this.lstArrivals.Location = new System.Drawing.Point(74, 338);
            this.lstArrivals.Name = "lstArrivals";
            this.lstArrivals.Size = new System.Drawing.Size(502, 124);
            this.lstArrivals.TabIndex = 1;
            // 
            // lstOnStation
            // 
            this.lstOnStation.FormattingEnabled = true;
            this.lstOnStation.ItemHeight = 15;
            this.lstOnStation.Location = new System.Drawing.Point(782, 79);
            this.lstOnStation.Name = "lstOnStation";
            this.lstOnStation.Size = new System.Drawing.Size(356, 199);
            this.lstOnStation.TabIndex = 2;
            // 
            // lstDepartures
            // 
            this.lstDepartures.FormattingEnabled = true;
            this.lstDepartures.ItemHeight = 15;
            this.lstDepartures.Location = new System.Drawing.Point(74, 468);
            this.lstDepartures.Name = "lstDepartures";
            this.lstDepartures.Size = new System.Drawing.Size(502, 124);
            this.lstDepartures.TabIndex = 3;
            // 
            // lstLocal
            // 
            this.lstLocal.FormattingEnabled = true;
            this.lstLocal.ItemHeight = 15;
            this.lstLocal.Location = new System.Drawing.Point(782, 338);
            this.lstLocal.Name = "lstLocal";
            this.lstLocal.Size = new System.Drawing.Size(356, 259);
            this.lstLocal.TabIndex = 4;
            // 
            // frmTrafficLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 634);
            this.Controls.Add(this.lstLocal);
            this.Controls.Add(this.lstDepartures);
            this.Controls.Add(this.lstOnStation);
            this.Controls.Add(this.lstArrivals);
            this.Controls.Add(this.lstPPR);
            this.Name = "frmTrafficLog";
            this.Text = "Traffic Log";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstPPR;
        private ListBox lstArrivals;
        private ListBox lstOnStation;
        private ListBox lstDepartures;
        private ListBox lstLocal;
    }
}