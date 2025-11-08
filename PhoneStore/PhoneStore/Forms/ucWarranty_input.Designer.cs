namespace PhoneStore.Forms
{
    partial class ucWarranty_input
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbInputWarr = new System.Windows.Forms.GroupBox();
            this.txtWarr_detail = new System.Windows.Forms.TextBox();
            this.lbWarr_detail = new System.Windows.Forms.Label();
            this.txtWarr_duration = new System.Windows.Forms.TextBox();
            this.lbWarr_duration = new System.Windows.Forms.Label();
            this.txtWarr_name = new System.Windows.Forms.TextBox();
            this.lbWarr_name = new System.Windows.Forms.Label();
            this.lbWarr_Warranty_ID = new System.Windows.Forms.Label();
            this.cbWarr_WarrantyID = new System.Windows.Forms.ComboBox();
            this.gbInputWarr.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInputWarr
            // 
            this.gbInputWarr.Controls.Add(this.txtWarr_detail);
            this.gbInputWarr.Controls.Add(this.lbWarr_detail);
            this.gbInputWarr.Controls.Add(this.txtWarr_duration);
            this.gbInputWarr.Controls.Add(this.lbWarr_duration);
            this.gbInputWarr.Controls.Add(this.txtWarr_name);
            this.gbInputWarr.Controls.Add(this.lbWarr_name);
            this.gbInputWarr.Controls.Add(this.lbWarr_Warranty_ID);
            this.gbInputWarr.Controls.Add(this.cbWarr_WarrantyID);
            this.gbInputWarr.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbInputWarr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbInputWarr.Location = new System.Drawing.Point(42, 28);
            this.gbInputWarr.Name = "gbInputWarr";
            this.gbInputWarr.Size = new System.Drawing.Size(437, 370);
            this.gbInputWarr.TabIndex = 17;
            this.gbInputWarr.TabStop = false;
            this.gbInputWarr.Text = "Warranty";
            // 
            // txtWarr_detail
            // 
            this.txtWarr_detail.Location = new System.Drawing.Point(10, 150);
            this.txtWarr_detail.Name = "txtWarr_detail";
            this.txtWarr_detail.Size = new System.Drawing.Size(417, 30);
            this.txtWarr_detail.TabIndex = 25;
            // 
            // lbWarr_detail
            // 
            this.lbWarr_detail.AutoSize = true;
            this.lbWarr_detail.Location = new System.Drawing.Point(6, 125);
            this.lbWarr_detail.Name = "lbWarr_detail";
            this.lbWarr_detail.Size = new System.Drawing.Size(68, 22);
            this.lbWarr_detail.TabIndex = 24;
            this.lbWarr_detail.Text = "Details";
            // 
            // txtWarr_duration
            // 
            this.txtWarr_duration.Location = new System.Drawing.Point(10, 322);
            this.txtWarr_duration.Name = "txtWarr_duration";
            this.txtWarr_duration.Size = new System.Drawing.Size(417, 30);
            this.txtWarr_duration.TabIndex = 23;
            // 
            // lbWarr_duration
            // 
            this.lbWarr_duration.AutoSize = true;
            this.lbWarr_duration.Location = new System.Drawing.Point(6, 297);
            this.lbWarr_duration.Name = "lbWarr_duration";
            this.lbWarr_duration.Size = new System.Drawing.Size(84, 22);
            this.lbWarr_duration.TabIndex = 21;
            this.lbWarr_duration.Text = "Duration";
            // 
            // txtWarr_name
            // 
            this.txtWarr_name.Location = new System.Drawing.Point(10, 236);
            this.txtWarr_name.Name = "txtWarr_name";
            this.txtWarr_name.Size = new System.Drawing.Size(417, 30);
            this.txtWarr_name.TabIndex = 19;
            // 
            // lbWarr_name
            // 
            this.lbWarr_name.AutoSize = true;
            this.lbWarr_name.Location = new System.Drawing.Point(6, 211);
            this.lbWarr_name.Name = "lbWarr_name";
            this.lbWarr_name.Size = new System.Drawing.Size(145, 22);
            this.lbWarr_name.TabIndex = 18;
            this.lbWarr_name.Text = "Warranty name";
            // 
            // lbWarr_Warranty_ID
            // 
            this.lbWarr_Warranty_ID.AutoSize = true;
            this.lbWarr_Warranty_ID.Location = new System.Drawing.Point(6, 39);
            this.lbWarr_Warranty_ID.Name = "lbWarr_Warranty_ID";
            this.lbWarr_Warranty_ID.Size = new System.Drawing.Size(111, 22);
            this.lbWarr_Warranty_ID.TabIndex = 17;
            this.lbWarr_Warranty_ID.Text = "Warranty ID\r\n";
            // 
            // cbWarr_WarrantyID
            // 
            this.cbWarr_WarrantyID.FormattingEnabled = true;
            this.cbWarr_WarrantyID.Location = new System.Drawing.Point(6, 64);
            this.cbWarr_WarrantyID.Name = "cbWarr_WarrantyID";
            this.cbWarr_WarrantyID.Size = new System.Drawing.Size(421, 30);
            this.cbWarr_WarrantyID.TabIndex = 16;
            // 
            // ucWarranty_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbInputWarr);
            this.Name = "ucWarranty_input";
            this.Size = new System.Drawing.Size(521, 619);
            this.Load += new System.EventHandler(this.ucWarranty_input_Load);
            this.gbInputWarr.ResumeLayout(false);
            this.gbInputWarr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbInputWarr;
        internal System.Windows.Forms.TextBox txtWarr_detail;
        private System.Windows.Forms.Label lbWarr_detail;
        internal System.Windows.Forms.TextBox txtWarr_duration;
        private System.Windows.Forms.Label lbWarr_duration;
        internal System.Windows.Forms.TextBox txtWarr_name;
        private System.Windows.Forms.Label lbWarr_name;
        private System.Windows.Forms.Label lbWarr_Warranty_ID;
        internal System.Windows.Forms.ComboBox cbWarr_WarrantyID;
    }
}
