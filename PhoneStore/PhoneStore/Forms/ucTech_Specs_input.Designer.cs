namespace PhoneStore.Forms
{
    partial class ucTech_Specs_input
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
            this.gbInputTS = new System.Windows.Forms.GroupBox();
            this.txtTS_Tech_name = new System.Windows.Forms.TextBox();
            this.lbTS_tech_name = new System.Windows.Forms.Label();
            this.txtTS_Details = new System.Windows.Forms.TextBox();
            this.lbTS_detail = new System.Windows.Forms.Label();
            this.lbTS_Product_ID = new System.Windows.Forms.Label();
            this.cbTS_ProductID = new System.Windows.Forms.ComboBox();
            this.gbInputTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInputTS
            // 
            this.gbInputTS.Controls.Add(this.txtTS_Tech_name);
            this.gbInputTS.Controls.Add(this.lbTS_tech_name);
            this.gbInputTS.Controls.Add(this.txtTS_Details);
            this.gbInputTS.Controls.Add(this.lbTS_detail);
            this.gbInputTS.Controls.Add(this.lbTS_Product_ID);
            this.gbInputTS.Controls.Add(this.cbTS_ProductID);
            this.gbInputTS.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInputTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbInputTS.Location = new System.Drawing.Point(9, 9);
            this.gbInputTS.Name = "gbInputTS";
            this.gbInputTS.Size = new System.Drawing.Size(465, 249);
            this.gbInputTS.TabIndex = 17;
            this.gbInputTS.TabStop = false;
            this.gbInputTS.Text = "Technical Specification";
            // 
            // txtTS_Tech_name
            // 
            this.txtTS_Tech_name.Location = new System.Drawing.Point(28, 124);
            this.txtTS_Tech_name.Name = "txtTS_Tech_name";
            this.txtTS_Tech_name.Size = new System.Drawing.Size(414, 30);
            this.txtTS_Tech_name.TabIndex = 25;
            // 
            // lbTS_tech_name
            // 
            this.lbTS_tech_name.AutoSize = true;
            this.lbTS_tech_name.Location = new System.Drawing.Point(25, 99);
            this.lbTS_tech_name.Name = "lbTS_tech_name";
            this.lbTS_tech_name.Size = new System.Drawing.Size(153, 22);
            this.lbTS_tech_name.TabIndex = 24;
            this.lbTS_tech_name.Text = "Technical name";
            // 
            // txtTS_Details
            // 
            this.txtTS_Details.Location = new System.Drawing.Point(29, 207);
            this.txtTS_Details.Name = "txtTS_Details";
            this.txtTS_Details.Size = new System.Drawing.Size(414, 30);
            this.txtTS_Details.TabIndex = 19;
            // 
            // lbTS_detail
            // 
            this.lbTS_detail.AutoSize = true;
            this.lbTS_detail.Location = new System.Drawing.Point(26, 182);
            this.lbTS_detail.Name = "lbTS_detail";
            this.lbTS_detail.Size = new System.Drawing.Size(68, 22);
            this.lbTS_detail.TabIndex = 18;
            this.lbTS_detail.Text = "Details";
            // 
            // lbTS_Product_ID
            // 
            this.lbTS_Product_ID.AutoSize = true;
            this.lbTS_Product_ID.Location = new System.Drawing.Point(24, 52);
            this.lbTS_Product_ID.Name = "lbTS_Product_ID";
            this.lbTS_Product_ID.Size = new System.Drawing.Size(100, 22);
            this.lbTS_Product_ID.TabIndex = 17;
            this.lbTS_Product_ID.Text = "Product ID";
            // 
            // cbTS_ProductID
            // 
            this.cbTS_ProductID.FormattingEnabled = true;
            this.cbTS_ProductID.Location = new System.Drawing.Point(164, 48);
            this.cbTS_ProductID.Name = "cbTS_ProductID";
            this.cbTS_ProductID.Size = new System.Drawing.Size(279, 30);
            this.cbTS_ProductID.TabIndex = 16;
            // 
            // ucTech_Specs_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbInputTS);
            this.Name = "ucTech_Specs_input";
            this.Size = new System.Drawing.Size(490, 567);
            this.Load += new System.EventHandler(this.ucTech_Specs_input_Load);
            this.gbInputTS.ResumeLayout(false);
            this.gbInputTS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbInputTS;
        internal System.Windows.Forms.TextBox txtTS_Tech_name;
        private System.Windows.Forms.Label lbTS_tech_name;
        internal System.Windows.Forms.TextBox txtTS_Details;
        private System.Windows.Forms.Label lbTS_detail;
        private System.Windows.Forms.Label lbTS_Product_ID;
        internal System.Windows.Forms.ComboBox cbTS_ProductID;
    }
}
