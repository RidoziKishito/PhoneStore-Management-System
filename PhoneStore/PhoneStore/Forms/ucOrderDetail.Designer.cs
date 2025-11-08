namespace PhoneStore.Forms
{
    partial class ucOrderDetail
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
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.imei_sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbOrderDetailInfo = new System.Windows.Forms.GroupBox();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.cbImeiSN = new System.Windows.Forms.ComboBox();
            this.btnAddOrderDetail = new System.Windows.Forms.Button();
            this.btnDeleteOrderDetail = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.lblImeiSN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.gbOrderDetailInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imei_sn,
            this.discount,
            this.selling_price});
            this.dgvOrderDetails.Location = new System.Drawing.Point(603, 6);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.RowTemplate.Height = 24;
            this.dgvOrderDetails.Size = new System.Drawing.Size(760, 272);
            this.dgvOrderDetails.TabIndex = 10;
            // 
            // imei_sn
            // 
            this.imei_sn.HeaderText = "imei_sn";
            this.imei_sn.MinimumWidth = 6;
            this.imei_sn.Name = "imei_sn";
            // 
            // discount
            // 
            this.discount.HeaderText = "discount";
            this.discount.MinimumWidth = 6;
            this.discount.Name = "discount";
            // 
            // selling_price
            // 
            this.selling_price.HeaderText = "selling_price";
            this.selling_price.MinimumWidth = 6;
            this.selling_price.Name = "selling_price";
            // 
            // gbOrderDetailInfo
            // 
            this.gbOrderDetailInfo.Controls.Add(this.btnAddRow);
            this.gbOrderDetailInfo.Controls.Add(this.txtSellingPrice);
            this.gbOrderDetailInfo.Controls.Add(this.nudDiscount);
            this.gbOrderDetailInfo.Controls.Add(this.cbImeiSN);
            this.gbOrderDetailInfo.Controls.Add(this.btnAddOrderDetail);
            this.gbOrderDetailInfo.Controls.Add(this.btnDeleteOrderDetail);
            this.gbOrderDetailInfo.Controls.Add(this.lblDiscount);
            this.gbOrderDetailInfo.Controls.Add(this.lblSellingPrice);
            this.gbOrderDetailInfo.Controls.Add(this.lblImeiSN);
            this.gbOrderDetailInfo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbOrderDetailInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbOrderDetailInfo.Location = new System.Drawing.Point(3, 6);
            this.gbOrderDetailInfo.Name = "gbOrderDetailInfo";
            this.gbOrderDetailInfo.Size = new System.Drawing.Size(594, 272);
            this.gbOrderDetailInfo.TabIndex = 15;
            this.gbOrderDetailInfo.TabStop = false;
            this.gbOrderDetailInfo.Text = "Order Detail ";
            this.gbOrderDetailInfo.Enter += new System.EventHandler(this.gbOrderDetailInfo_Enter);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(357, 189);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(109, 77);
            this.btnAddRow.TabIndex = 28;
            this.btnAddRow.Text = "Add";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(178, 144);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.ReadOnly = true;
            this.txtSellingPrice.Size = new System.Drawing.Size(403, 30);
            this.txtSellingPrice.TabIndex = 27;
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(178, 37);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(404, 30);
            this.nudDiscount.TabIndex = 26;
            this.nudDiscount.ValueChanged += new System.EventHandler(this.nudDiscount_ValueChanged);
            // 
            // cbImeiSN
            // 
            this.cbImeiSN.FormattingEnabled = true;
            this.cbImeiSN.Location = new System.Drawing.Point(178, 92);
            this.cbImeiSN.Name = "cbImeiSN";
            this.cbImeiSN.Size = new System.Drawing.Size(404, 30);
            this.cbImeiSN.TabIndex = 17;
            this.cbImeiSN.SelectedIndexChanged += new System.EventHandler(this.cbImeiSN_SelectedIndexChanged);
            // 
            // btnAddOrderDetail
            // 
            this.btnAddOrderDetail.Location = new System.Drawing.Point(472, 189);
            this.btnAddOrderDetail.Name = "btnAddOrderDetail";
            this.btnAddOrderDetail.Size = new System.Drawing.Size(109, 77);
            this.btnAddOrderDetail.TabIndex = 14;
            this.btnAddOrderDetail.Text = "Confirm";
            this.btnAddOrderDetail.UseVisualStyleBackColor = true;
            this.btnAddOrderDetail.Click += new System.EventHandler(this.btnAddOrderDetail_Click);
            // 
            // btnDeleteOrderDetail
            // 
            this.btnDeleteOrderDetail.Location = new System.Drawing.Point(242, 189);
            this.btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            this.btnDeleteOrderDetail.Size = new System.Drawing.Size(109, 77);
            this.btnDeleteOrderDetail.TabIndex = 15;
            this.btnDeleteOrderDetail.Text = "Delete";
            this.btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            this.btnDeleteOrderDetail.Click += new System.EventHandler(this.btnDeleteOrderDetail_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(81, 45);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(91, 22);
            this.lblDiscount.TabIndex = 8;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Location = new System.Drawing.Point(50, 152);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(122, 22);
            this.lblSellingPrice.TabIndex = 9;
            this.lblSellingPrice.Text = "Selling price:";
            // 
            // lblImeiSN
            // 
            this.lblImeiSN.AutoSize = true;
            this.lblImeiSN.Location = new System.Drawing.Point(9, 100);
            this.lblImeiSN.Name = "lblImeiSN";
            this.lblImeiSN.Size = new System.Drawing.Size(163, 22);
            this.lblImeiSN.TabIndex = 7;
            this.lblImeiSN.Text = "IMEI SN - Product:";
            // 
            // ucOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.gbOrderDetailInfo);
            this.Name = "ucOrderDetail";
            this.Size = new System.Drawing.Size(1366, 281);
            this.Load += new System.EventHandler(this.ucOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.gbOrderDetailInfo.ResumeLayout(false);
            this.gbOrderDetailInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvOrderDetails;
        public System.Windows.Forms.GroupBox gbOrderDetailInfo;
        public System.Windows.Forms.ComboBox cbImeiSN;
        public System.Windows.Forms.Button btnDeleteOrderDetail;
        public System.Windows.Forms.Button btnAddOrderDetail;
        public System.Windows.Forms.Label lblDiscount;
        public System.Windows.Forms.Label lblSellingPrice;
        public System.Windows.Forms.Label lblImeiSN;
        public System.Windows.Forms.NumericUpDown nudDiscount;
        public System.Windows.Forms.TextBox txtSellingPrice;
        public System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn imei_sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn selling_price;
    }
}
