namespace PhoneStore.Forms
{
    partial class ucOrder
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
            this.gpOrderDisplay = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblLoadOrdersByDate = new System.Windows.Forms.Label();
            this.btnTotalRevenue = new System.Windows.Forms.Button();
            this.cbLoadOrdersByStatus = new System.Windows.Forms.ComboBox();
            this.dtpLoadOrdersByDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblLoadOrdersByStatus = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnByDate = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnByStatus = new System.Windows.Forms.Button();
            this.btnByCustomer = new System.Windows.Forms.Button();
            this.lblLoadOrdersByCustomer = new System.Windows.Forms.Label();
            this.cbLoadOrdersByCustomer = new System.Windows.Forms.ComboBox();
            this.gbOrderInfo = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.cbPromotionID = new System.Windows.Forms.ComboBox();
            this.cbEmployeeID = new System.Windows.Forms.ComboBox();
            this.cbCustomerID = new System.Windows.Forms.ComboBox();
            this.lblPromotionID = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.txtTotalValue = new System.Windows.Forms.TextBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.ucOrderDetail = new PhoneStore.Forms.ucOrderDetail();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.gpOrderDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbOrderInfo.SuspendLayout();
            this.gbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpOrderDisplay
            // 
            this.gpOrderDisplay.Controls.Add(this.dgvOrders);
            this.gpOrderDisplay.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gpOrderDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gpOrderDisplay.Location = new System.Drawing.Point(689, 3);
            this.gpOrderDisplay.Name = "gpOrderDisplay";
            this.gpOrderDisplay.Size = new System.Drawing.Size(692, 473);
            this.gpOrderDisplay.TabIndex = 14;
            this.gpOrderDisplay.TabStop = false;
            this.gpOrderDisplay.Text = "Order Display";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(6, 25);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(680, 442);
            this.dgvOrders.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalRevenue);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.lblLoadOrdersByDate);
            this.groupBox1.Controls.Add(this.btnTotalRevenue);
            this.groupBox1.Controls.Add(this.cbLoadOrdersByStatus);
            this.groupBox1.Controls.Add(this.dtpLoadOrdersByDate);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.lblLoadOrdersByStatus);
            this.groupBox1.Controls.Add(this.lblStartDate);
            this.groupBox1.Controls.Add(this.btnByDate);
            this.groupBox1.Controls.Add(this.lblEndDate);
            this.groupBox1.Controls.Add(this.btnByStatus);
            this.groupBox1.Controls.Add(this.btnByCustomer);
            this.groupBox1.Controls.Add(this.lblLoadOrdersByCustomer);
            this.groupBox1.Controls.Add(this.cbLoadOrdersByCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 185);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Options";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.dtpEnd.Location = new System.Drawing.Point(273, 152);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(254, 23);
            this.dtpEnd.TabIndex = 38;
            // 
            // lblLoadOrdersByDate
            // 
            this.lblLoadOrdersByDate.AutoSize = true;
            this.lblLoadOrdersByDate.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadOrdersByDate.Location = new System.Drawing.Point(66, 32);
            this.lblLoadOrdersByDate.Name = "lblLoadOrdersByDate";
            this.lblLoadOrdersByDate.Size = new System.Drawing.Size(165, 18);
            this.lblLoadOrdersByDate.TabIndex = 26;
            this.lblLoadOrdersByDate.Text = "Load Orders By Date:";
            // 
            // btnTotalRevenue
            // 
            this.btnTotalRevenue.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalRevenue.Location = new System.Drawing.Point(533, 118);
            this.btnTotalRevenue.Name = "btnTotalRevenue";
            this.btnTotalRevenue.Size = new System.Drawing.Size(75, 61);
            this.btnTotalRevenue.TabIndex = 39;
            this.btnTotalRevenue.Text = "Total";
            this.btnTotalRevenue.UseVisualStyleBackColor = true;
            this.btnTotalRevenue.Click += new System.EventHandler(this.btnTotalRevenue_Click);
            // 
            // cbLoadOrdersByStatus
            // 
            this.cbLoadOrdersByStatus.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoadOrdersByStatus.FormattingEnabled = true;
            this.cbLoadOrdersByStatus.Location = new System.Drawing.Point(273, 54);
            this.cbLoadOrdersByStatus.Name = "cbLoadOrdersByStatus";
            this.cbLoadOrdersByStatus.Size = new System.Drawing.Size(254, 24);
            this.cbLoadOrdersByStatus.TabIndex = 27;
            // 
            // dtpLoadOrdersByDate
            // 
            this.dtpLoadOrdersByDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLoadOrdersByDate.Location = new System.Drawing.Point(273, 25);
            this.dtpLoadOrdersByDate.Name = "dtpLoadOrdersByDate";
            this.dtpLoadOrdersByDate.Size = new System.Drawing.Size(254, 23);
            this.dtpLoadOrdersByDate.TabIndex = 28;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.dtpStart.Location = new System.Drawing.Point(273, 123);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(254, 23);
            this.dtpStart.TabIndex = 37;
            // 
            // lblLoadOrdersByStatus
            // 
            this.lblLoadOrdersByStatus.AutoSize = true;
            this.lblLoadOrdersByStatus.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadOrdersByStatus.Location = new System.Drawing.Point(66, 60);
            this.lblLoadOrdersByStatus.Name = "lblLoadOrdersByStatus";
            this.lblLoadOrdersByStatus.Size = new System.Drawing.Size(173, 18);
            this.lblLoadOrdersByStatus.TabIndex = 29;
            this.lblLoadOrdersByStatus.Text = "Load Orders By Status:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(177, 128);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(85, 18);
            this.lblStartDate.TabIndex = 35;
            this.lblStartDate.Text = "Start Date:";
            // 
            // btnByDate
            // 
            this.btnByDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByDate.Location = new System.Drawing.Point(533, 21);
            this.btnByDate.Name = "btnByDate";
            this.btnByDate.Size = new System.Drawing.Size(75, 27);
            this.btnByDate.TabIndex = 30;
            this.btnByDate.Text = "Load";
            this.btnByDate.UseVisualStyleBackColor = true;
            this.btnByDate.Click += new System.EventHandler(this.btnByDate_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(183, 157);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(79, 18);
            this.lblEndDate.TabIndex = 36;
            this.lblEndDate.Text = "End Date:";
            // 
            // btnByStatus
            // 
            this.btnByStatus.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByStatus.Location = new System.Drawing.Point(533, 51);
            this.btnByStatus.Name = "btnByStatus";
            this.btnByStatus.Size = new System.Drawing.Size(75, 27);
            this.btnByStatus.TabIndex = 31;
            this.btnByStatus.Text = "Load";
            this.btnByStatus.UseVisualStyleBackColor = true;
            this.btnByStatus.Click += new System.EventHandler(this.btnByStatus_Click);
            // 
            // btnByCustomer
            // 
            this.btnByCustomer.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByCustomer.Location = new System.Drawing.Point(533, 81);
            this.btnByCustomer.Name = "btnByCustomer";
            this.btnByCustomer.Size = new System.Drawing.Size(75, 27);
            this.btnByCustomer.TabIndex = 34;
            this.btnByCustomer.Text = "Load";
            this.btnByCustomer.UseVisualStyleBackColor = true;
            this.btnByCustomer.Click += new System.EventHandler(this.btnByCustomer_Click);
            // 
            // lblLoadOrdersByCustomer
            // 
            this.lblLoadOrdersByCustomer.AutoSize = true;
            this.lblLoadOrdersByCustomer.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadOrdersByCustomer.Location = new System.Drawing.Point(66, 90);
            this.lblLoadOrdersByCustomer.Name = "lblLoadOrdersByCustomer";
            this.lblLoadOrdersByCustomer.Size = new System.Drawing.Size(201, 18);
            this.lblLoadOrdersByCustomer.TabIndex = 32;
            this.lblLoadOrdersByCustomer.Text = "Load Orders By Customer:";
            // 
            // cbLoadOrdersByCustomer
            // 
            this.cbLoadOrdersByCustomer.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoadOrdersByCustomer.FormattingEnabled = true;
            this.cbLoadOrdersByCustomer.Location = new System.Drawing.Point(273, 84);
            this.cbLoadOrdersByCustomer.Name = "cbLoadOrdersByCustomer";
            this.cbLoadOrdersByCustomer.Size = new System.Drawing.Size(254, 24);
            this.cbLoadOrdersByCustomer.TabIndex = 33;
            // 
            // gbOrderInfo
            // 
            this.gbOrderInfo.Controls.Add(this.cbStatus);
            this.gbOrderInfo.Controls.Add(this.lblStatus);
            this.gbOrderInfo.Controls.Add(this.dtpSaleDate);
            this.gbOrderInfo.Controls.Add(this.lblSaleDate);
            this.gbOrderInfo.Controls.Add(this.cbPayment);
            this.gbOrderInfo.Controls.Add(this.cbPromotionID);
            this.gbOrderInfo.Controls.Add(this.cbEmployeeID);
            this.gbOrderInfo.Controls.Add(this.cbCustomerID);
            this.gbOrderInfo.Controls.Add(this.lblPromotionID);
            this.gbOrderInfo.Controls.Add(this.lblPayment);
            this.gbOrderInfo.Controls.Add(this.lblEmployeeID);
            this.gbOrderInfo.Controls.Add(this.lblCustomerID);
            this.gbOrderInfo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbOrderInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbOrderInfo.Location = new System.Drawing.Point(9, 194);
            this.gbOrderInfo.Name = "gbOrderInfo";
            this.gbOrderInfo.Size = new System.Drawing.Size(674, 282);
            this.gbOrderInfo.TabIndex = 13;
            this.gbOrderInfo.TabStop = false;
            this.gbOrderInfo.Text = "Order Information";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(437, 78);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(231, 30);
            this.cbStatus.TabIndex = 23;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(366, 86);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 22);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status:";
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Location = new System.Drawing.Point(192, 168);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(476, 30);
            this.dtpSaleDate.TabIndex = 21;
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Location = new System.Drawing.Point(63, 174);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(99, 22);
            this.lblSaleDate.TabIndex = 20;
            this.lblSaleDate.Text = "Sale Date:";
            // 
            // cbPayment
            // 
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Location = new System.Drawing.Point(192, 122);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(476, 30);
            this.cbPayment.TabIndex = 19;
            // 
            // cbPromotionID
            // 
            this.cbPromotionID.FormattingEnabled = true;
            this.cbPromotionID.Location = new System.Drawing.Point(135, 78);
            this.cbPromotionID.Name = "cbPromotionID";
            this.cbPromotionID.Size = new System.Drawing.Size(223, 30);
            this.cbPromotionID.TabIndex = 18;
            // 
            // cbEmployeeID
            // 
            this.cbEmployeeID.FormattingEnabled = true;
            this.cbEmployeeID.Location = new System.Drawing.Point(476, 33);
            this.cbEmployeeID.Name = "cbEmployeeID";
            this.cbEmployeeID.Size = new System.Drawing.Size(192, 30);
            this.cbEmployeeID.TabIndex = 17;
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.FormattingEnabled = true;
            this.cbCustomerID.Location = new System.Drawing.Point(114, 33);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Size = new System.Drawing.Size(244, 30);
            this.cbCustomerID.TabIndex = 16;
            // 
            // lblPromotionID
            // 
            this.lblPromotionID.AutoSize = true;
            this.lblPromotionID.Location = new System.Drawing.Point(6, 86);
            this.lblPromotionID.Name = "lblPromotionID";
            this.lblPromotionID.Size = new System.Drawing.Size(127, 22);
            this.lblPromotionID.TabIndex = 8;
            this.lblPromotionID.Text = "Promotion ID:";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(8, 130);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(165, 22);
            this.lblPayment.TabIndex = 9;
            this.lblPayment.Text = "Payment Method:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(367, 36);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(103, 22);
            this.lblEmployeeID.TabIndex = 7;
            this.lblEmployeeID.Text = "Employee:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(8, 36);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(100, 22);
            this.lblCustomerID.TabIndex = 6;
            this.lblCustomerID.Text = "Customer:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(26, 37);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(56, 22);
            this.lblTotalValue.TabIndex = 25;
            this.lblTotalValue.Text = "Total:";
            // 
            // txtTotalValue
            // 
            this.txtTotalValue.Location = new System.Drawing.Point(88, 29);
            this.txtTotalValue.Name = "txtTotalValue";
            this.txtTotalValue.ReadOnly = true;
            this.txtTotalValue.Size = new System.Drawing.Size(264, 30);
            this.txtTotalValue.TabIndex = 24;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(444, 19);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(101, 44);
            this.btnDeleteOrder.TabIndex = 15;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(370, 19);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(68, 44);
            this.btnAddOrder.TabIndex = 14;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.btnReload);
            this.gbAction.Controls.Add(this.btnAddOrder);
            this.gbAction.Controls.Add(this.lblTotalValue);
            this.gbAction.Controls.Add(this.btnDeleteOrder);
            this.gbAction.Controls.Add(this.txtTotalValue);
            this.gbAction.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbAction.Location = new System.Drawing.Point(15, 398);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(662, 72);
            this.gbAction.TabIndex = 26;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Action";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(551, 19);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(101, 44);
            this.btnReload.TabIndex = 26;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // ucOrderDetail
            // 
            this.ucOrderDetail.Location = new System.Drawing.Point(9, 482);
            this.ucOrderDetail.Name = "ucOrderDetail";
            this.ucOrderDetail.Size = new System.Drawing.Size(1366, 281);
            this.ucOrderDetail.TabIndex = 15;
            this.ucOrderDetail.Load += new System.EventHandler(this.ucOrderDetail_Load);
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(64, 118);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(112, 58);
            this.lblTotalRevenue.TabIndex = 40;
            this.lblTotalRevenue.Text = "Total\r\nRevenue\r\n";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.ucOrderDetail);
            this.Controls.Add(this.gpOrderDisplay);
            this.Controls.Add(this.gbOrderInfo);
            this.Name = "ucOrder";
            this.Size = new System.Drawing.Size(1384, 766);
            this.Load += new System.EventHandler(this.ucOrder_Load);
            this.gpOrderDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOrderInfo.ResumeLayout(false);
            this.gbOrderInfo.PerformLayout();
            this.gbAction.ResumeLayout(false);
            this.gbAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gpOrderDisplay;
        public System.Windows.Forms.DataGridView dgvOrders;
        public System.Windows.Forms.GroupBox gbOrderInfo;
        public System.Windows.Forms.Button btnDeleteOrder;
        public System.Windows.Forms.Button btnAddOrder;
        public System.Windows.Forms.Label lblPromotionID;
        public System.Windows.Forms.Label lblPayment;
        public System.Windows.Forms.Label lblEmployeeID;
        public System.Windows.Forms.Label lblCustomerID;
        public System.Windows.Forms.ComboBox cbCustomerID;
        public System.Windows.Forms.ComboBox cbEmployeeID;
        public System.Windows.Forms.ComboBox cbPromotionID;
        public System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.DateTimePicker dtpSaleDate;
        public System.Windows.Forms.Label lblSaleDate;
        public System.Windows.Forms.ComboBox cbPayment;
        public System.Windows.Forms.Label lblTotalValue;
        public System.Windows.Forms.TextBox txtTotalValue;
        public System.Windows.Forms.ComboBox cbLoadOrdersByStatus;
        public System.Windows.Forms.Label lblLoadOrdersByDate;
        public System.Windows.Forms.Label lblLoadOrdersByStatus;
        public System.Windows.Forms.DateTimePicker dtpLoadOrdersByDate;
        public System.Windows.Forms.Button btnByStatus;
        public System.Windows.Forms.Button btnByDate;
        public System.Windows.Forms.Button btnByCustomer;
        public System.Windows.Forms.ComboBox cbLoadOrdersByCustomer;
        public System.Windows.Forms.Label lblLoadOrdersByCustomer;
        public System.Windows.Forms.Button btnTotalRevenue;
        public System.Windows.Forms.DateTimePicker dtpEnd;
        public System.Windows.Forms.DateTimePicker dtpStart;
        public System.Windows.Forms.Label lblStartDate;
        public System.Windows.Forms.Label lblEndDate;
        public System.Windows.Forms.GroupBox groupBox1;
        public ucOrderDetail ucOrderDetail;
        public System.Windows.Forms.GroupBox gbAction;
        public System.Windows.Forms.Button btnReload;
        public System.Windows.Forms.Label lblTotalRevenue;
    }
}
