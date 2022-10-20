namespace AeroStat_Beta
{
    partial class MaterialInputBox
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
            this.mbOK = new MaterialSkin.Controls.MaterialButton();
            this.mbCancel = new MaterialSkin.Controls.MaterialButton();
            this.mLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mtbInput = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // mbOK
            // 
            this.mbOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbOK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbOK.Depth = 0;
            this.mbOK.HighEmphasis = true;
            this.mbOK.Icon = null;
            this.mbOK.Location = new System.Drawing.Point(283, 228);
            this.mbOK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbOK.Name = "mbOK";
            this.mbOK.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbOK.Size = new System.Drawing.Size(64, 36);
            this.mbOK.TabIndex = 0;
            this.mbOK.Text = "OK";
            this.mbOK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbOK.UseAccentColor = false;
            this.mbOK.UseVisualStyleBackColor = true;
            this.mbOK.Click += new System.EventHandler(this.mbOK_Click);
            // 
            // mbCancel
            // 
            this.mbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbCancel.Depth = 0;
            this.mbCancel.HighEmphasis = true;
            this.mbCancel.Icon = null;
            this.mbCancel.Location = new System.Drawing.Point(198, 228);
            this.mbCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbCancel.Size = new System.Drawing.Size(77, 36);
            this.mbCancel.TabIndex = 1;
            this.mbCancel.Text = "Cancel";
            this.mbCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbCancel.UseAccentColor = false;
            this.mbCancel.UseVisualStyleBackColor = true;
            this.mbCancel.Click += new System.EventHandler(this.mbCancel_Click);
            // 
            // mLabel
            // 
            this.mLabel.Depth = 0;
            this.mLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mLabel.Location = new System.Drawing.Point(3, 64);
            this.mLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.mLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(348, 105);
            this.mLabel.TabIndex = 2;
            this.mLabel.Text = "materialLabel1";
            this.mLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbInput
            // 
            this.mtbInput.AnimateReadOnly = false;
            this.mtbInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbInput.Depth = 0;
            this.mtbInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.mtbInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbInput.LeadingIcon = null;
            this.mtbInput.Location = new System.Drawing.Point(3, 169);
            this.mtbInput.MaxLength = 50;
            this.mtbInput.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbInput.Multiline = false;
            this.mtbInput.Name = "mtbInput";
            this.mtbInput.Size = new System.Drawing.Size(348, 50);
            this.mtbInput.TabIndex = 0;
            this.mtbInput.Text = "";
            this.mtbInput.TrailingIcon = null;
            // 
            // MaterialInputBox
            // 
            this.AcceptButton = this.mbOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.mbCancel;
            this.ClientSize = new System.Drawing.Size(354, 287);
            this.Controls.Add(this.mtbInput);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mbOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(354, 287);
            this.Name = "MaterialInputBox";
            this.Sizable = false;
            this.Text = "MaterialInputBox";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.MaterialInputBox_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton mbOK;
        private MaterialSkin.Controls.MaterialButton mbCancel;
        private MaterialSkin.Controls.MaterialLabel mLabel;
        private MaterialSkin.Controls.MaterialTextBox mtbInput;
    }
}