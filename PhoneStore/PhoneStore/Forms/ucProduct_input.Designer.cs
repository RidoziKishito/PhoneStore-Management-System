namespace PhoneStore.Forms
{
    partial class ucProduct_input
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
            this.gbInputP = new System.Windows.Forms.GroupBox();
            this.txtP_imei = new System.Windows.Forms.TextBox();
            this.lbP_imei = new System.Windows.Forms.Label();
            this.cbP_warranty_id = new System.Windows.Forms.ComboBox();
            this.lbP_warranty_id = new System.Windows.Forms.Label();
            this.txtP_status = new System.Windows.Forms.TextBox();
            this.lbP_status = new System.Windows.Forms.Label();
            this.lbPM_Product_ID = new System.Windows.Forms.Label();
            this.cbP_ProductID = new System.Windows.Forms.ComboBox();
            this.gbInputP.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInputP
            // 
            this.gbInputP.Controls.Add(this.txtP_imei);
            this.gbInputP.Controls.Add(this.lbP_imei);
            this.gbInputP.Controls.Add(this.cbP_warranty_id);
            this.gbInputP.Controls.Add(this.lbP_warranty_id);
            this.gbInputP.Controls.Add(this.txtP_status);
            this.gbInputP.Controls.Add(this.lbP_status);
            this.gbInputP.Controls.Add(this.lbPM_Product_ID);
            this.gbInputP.Controls.Add(this.cbP_ProductID);
            this.gbInputP.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbInputP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbInputP.Location = new System.Drawing.Point(3, 3);
            this.gbInputP.Name = "gbInputP";
            this.gbInputP.Size = new System.Drawing.Size(484, 342);
            this.gbInputP.TabIndex = 17;
            this.gbInputP.TabStop = false;
            this.gbInputP.Text = "Product ";
            // 
            // txtP_imei
            // 
            this.txtP_imei.Location = new System.Drawing.Point(25, 65);
            this.txtP_imei.Name = "txtP_imei";
            this.txtP_imei.Size = new System.Drawing.Size(433, 30);
            this.txtP_imei.TabIndex = 29;
            // 
            // lbP_imei
            // 
            this.lbP_imei.AutoSize = true;
            this.lbP_imei.Location = new System.Drawing.Point(21, 40);
            this.lbP_imei.Name = "lbP_imei";
            this.lbP_imei.Size = new System.Drawing.Size(75, 22);
            this.lbP_imei.TabIndex = 28;
            this.lbP_imei.Text = "Imei/sn";
            // 
            // cbP_warranty_id
            // 
            this.cbP_warranty_id.FormattingEnabled = true;
            this.cbP_warranty_id.Location = new System.Drawing.Point(25, 219);
            this.cbP_warranty_id.Name = "cbP_warranty_id";
            this.cbP_warranty_id.Size = new System.Drawing.Size(433, 30);
            this.cbP_warranty_id.TabIndex = 25;
            // 
            // lbP_warranty_id
            // 
            this.lbP_warranty_id.AutoSize = true;
            this.lbP_warranty_id.Location = new System.Drawing.Point(21, 194);
            this.lbP_warranty_id.Name = "lbP_warranty_id";
            this.lbP_warranty_id.Size = new System.Drawing.Size(111, 22);
            this.lbP_warranty_id.TabIndex = 24;
            this.lbP_warranty_id.Text = "Warranty ID";
            // 
            // txtP_status
            // 
            this.txtP_status.Location = new System.Drawing.Point(25, 296);
            this.txtP_status.Name = "txtP_status";
            this.txtP_status.ReadOnly = true;
            this.txtP_status.Size = new System.Drawing.Size(433, 30);
            this.txtP_status.TabIndex = 19;
            this.txtP_status.Text = "New";
            // 
            // lbP_status
            // 
            this.lbP_status.AutoSize = true;
            this.lbP_status.Location = new System.Drawing.Point(21, 271);
            this.lbP_status.Name = "lbP_status";
            this.lbP_status.Size = new System.Drawing.Size(60, 22);
            this.lbP_status.TabIndex = 18;
            this.lbP_status.Text = "Status";
            // 
            // lbPM_Product_ID
            // 
            this.lbPM_Product_ID.AutoSize = true;
            this.lbPM_Product_ID.Location = new System.Drawing.Point(21, 117);
            this.lbPM_Product_ID.Name = "lbPM_Product_ID";
            this.lbPM_Product_ID.Size = new System.Drawing.Size(106, 22);
            this.lbPM_Product_ID.TabIndex = 17;
            this.lbPM_Product_ID.Text = "Product ID ";
            // 
            // cbP_ProductID
            // 
            this.cbP_ProductID.FormattingEnabled = true;
            this.cbP_ProductID.Location = new System.Drawing.Point(25, 142);
            this.cbP_ProductID.Name = "cbP_ProductID";
            this.cbP_ProductID.Size = new System.Drawing.Size(433, 30);
            this.cbP_ProductID.TabIndex = 16;
            // 
            // ucProduct_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbInputP);
            this.Name = "ucProduct_input";
            this.Size = new System.Drawing.Size(490, 505);
            this.Load += new System.EventHandler(this.ucProduct_input_Load);
            this.gbInputP.ResumeLayout(false);
            this.gbInputP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbInputP;
        private System.Windows.Forms.Label lbP_warranty_id;
        internal System.Windows.Forms.TextBox txtP_status;
        private System.Windows.Forms.Label lbP_status;
        private System.Windows.Forms.Label lbPM_Product_ID;
        internal System.Windows.Forms.ComboBox cbP_ProductID;
        internal System.Windows.Forms.ComboBox cbP_warranty_id;
        internal System.Windows.Forms.TextBox txtP_imei;
        private System.Windows.Forms.Label lbP_imei;
    }
}
