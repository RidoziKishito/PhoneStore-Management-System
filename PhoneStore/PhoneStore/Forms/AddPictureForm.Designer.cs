namespace PhoneStore.Forms
{
    partial class AddPictureForm
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
            this.lbPM_Product_name = new System.Windows.Forms.Label();
            this.txtPictureName = new System.Windows.Forms.TextBox();
            this.gbAddPicture = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbPM_Product_ID = new System.Windows.Forms.Label();
            this.cbP_ProductID = new System.Windows.Forms.ComboBox();
            this.gbAddPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPM_Product_name
            // 
            this.lbPM_Product_name.AutoSize = true;
            this.lbPM_Product_name.Location = new System.Drawing.Point(7, 37);
            this.lbPM_Product_name.Name = "lbPM_Product_name";
            this.lbPM_Product_name.Size = new System.Drawing.Size(135, 22);
            this.lbPM_Product_name.TabIndex = 24;
            this.lbPM_Product_name.Text = "Product name";
            // 
            // txtPictureName
            // 
            this.txtPictureName.Location = new System.Drawing.Point(6, 62);
            this.txtPictureName.Name = "txtPictureName";
            this.txtPictureName.Size = new System.Drawing.Size(391, 30);
            this.txtPictureName.TabIndex = 25;
            // 
            // gbAddPicture
            // 
            this.gbAddPicture.Controls.Add(this.lbPM_Product_ID);
            this.gbAddPicture.Controls.Add(this.cbP_ProductID);
            this.gbAddPicture.Controls.Add(this.btnOk);
            this.gbAddPicture.Controls.Add(this.txtPictureName);
            this.gbAddPicture.Controls.Add(this.lbPM_Product_name);
            this.gbAddPicture.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbAddPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbAddPicture.Location = new System.Drawing.Point(12, 12);
            this.gbAddPicture.Name = "gbAddPicture";
            this.gbAddPicture.Size = new System.Drawing.Size(487, 168);
            this.gbAddPicture.TabIndex = 17;
            this.gbAddPicture.TabStop = false;
            this.gbAddPicture.Text = "Add picture";
            this.gbAddPicture.Enter += new System.EventHandler(this.gbAddPicture_Enter);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(406, 62);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 100);
            this.btnOk.TabIndex = 26;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbPM_Product_ID
            // 
            this.lbPM_Product_ID.AutoSize = true;
            this.lbPM_Product_ID.Location = new System.Drawing.Point(7, 107);
            this.lbPM_Product_ID.Name = "lbPM_Product_ID";
            this.lbPM_Product_ID.Size = new System.Drawing.Size(106, 22);
            this.lbPM_Product_ID.TabIndex = 28;
            this.lbPM_Product_ID.Text = "Product ID ";
            // 
            // cbP_ProductID
            // 
            this.cbP_ProductID.FormattingEnabled = true;
            this.cbP_ProductID.Location = new System.Drawing.Point(6, 132);
            this.cbP_ProductID.Name = "cbP_ProductID";
            this.cbP_ProductID.Size = new System.Drawing.Size(391, 30);
            this.cbP_ProductID.TabIndex = 27;
            // 
            // AddPictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 192);
            this.Controls.Add(this.gbAddPicture);
            this.Name = "AddPictureForm";
            this.Text = "Add Picture";
            this.gbAddPicture.ResumeLayout(false);
            this.gbAddPicture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPM_Product_name;
        internal System.Windows.Forms.TextBox txtPictureName;
        internal System.Windows.Forms.GroupBox gbAddPicture;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbPM_Product_ID;
        internal System.Windows.Forms.ComboBox cbP_ProductID;
    }
}