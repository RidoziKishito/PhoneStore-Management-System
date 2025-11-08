namespace PhoneStore.Forms
{
    partial class ucProduct
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
            this.components = new System.ComponentModel.Container();
            this.btnPM_Show = new System.Windows.Forms.Button();
            this.gbP_ViewChoose = new System.Windows.Forms.GroupBox();
            this.lbP_View = new System.Windows.Forms.Label();
            this.cbP_veiwID = new System.Windows.Forms.ComboBox();
            this.gbTask = new System.Windows.Forms.GroupBox();
            this.btnPCancel = new System.Windows.Forms.Button();
            this.btnPSave = new System.Windows.Forms.Button();
            this.btnPReload = new System.Windows.Forms.Button();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPUpdate = new System.Windows.Forms.Button();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lblIcon = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnPInput = new System.Windows.Forms.Panel();
            this.gbP_ViewChoose.SuspendLayout();
            this.gbTask.SuspendLayout();
            this.gbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPM_Show
            // 
            this.btnPM_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPM_Show.Location = new System.Drawing.Point(635, 29);
            this.btnPM_Show.Name = "btnPM_Show";
            this.btnPM_Show.Size = new System.Drawing.Size(107, 45);
            this.btnPM_Show.TabIndex = 1;
            this.btnPM_Show.Text = "Show";
            this.btnPM_Show.UseVisualStyleBackColor = true;
            this.btnPM_Show.Click += new System.EventHandler(this.btnPM_Show_Click);
            // 
            // gbP_ViewChoose
            // 
            this.gbP_ViewChoose.Controls.Add(this.lbP_View);
            this.gbP_ViewChoose.Controls.Add(this.cbP_veiwID);
            this.gbP_ViewChoose.Controls.Add(this.btnPM_Show);
            this.gbP_ViewChoose.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbP_ViewChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbP_ViewChoose.Location = new System.Drawing.Point(12, 582);
            this.gbP_ViewChoose.Name = "gbP_ViewChoose";
            this.gbP_ViewChoose.Size = new System.Drawing.Size(764, 89);
            this.gbP_ViewChoose.TabIndex = 14;
            this.gbP_ViewChoose.TabStop = false;
            this.gbP_ViewChoose.Text = "Quantity of products in stock (New)";
            // 
            // lbP_View
            // 
            this.lbP_View.AutoSize = true;
            this.lbP_View.Location = new System.Drawing.Point(87, 45);
            this.lbP_View.Name = "lbP_View";
            this.lbP_View.Size = new System.Drawing.Size(101, 22);
            this.lbP_View.TabIndex = 6;
            this.lbP_View.Text = "Product ID";
            // 
            // cbP_veiwID
            // 
            this.cbP_veiwID.FormattingEnabled = true;
            this.cbP_veiwID.Location = new System.Drawing.Point(194, 39);
            this.cbP_veiwID.Name = "cbP_veiwID";
            this.cbP_veiwID.Size = new System.Drawing.Size(414, 30);
            this.cbP_veiwID.TabIndex = 5;
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.btnPCancel);
            this.gbTask.Controls.Add(this.btnPSave);
            this.gbTask.Controls.Add(this.btnPReload);
            this.gbTask.Controls.Add(this.btnPDelete);
            this.gbTask.Controls.Add(this.btnPUpdate);
            this.gbTask.Controls.Add(this.btnPAdd);
            this.gbTask.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbTask.Location = new System.Drawing.Point(782, 582);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(599, 89);
            this.gbTask.TabIndex = 17;
            this.gbTask.TabStop = false;
            this.gbTask.Text = "Tasks";
            // 
            // btnPCancel
            // 
            this.btnPCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCancel.Location = new System.Drawing.Point(101, 30);
            this.btnPCancel.Name = "btnPCancel";
            this.btnPCancel.Size = new System.Drawing.Size(89, 45);
            this.btnPCancel.TabIndex = 5;
            this.btnPCancel.Text = "Cancel";
            this.btnPCancel.UseVisualStyleBackColor = true;
            this.btnPCancel.Click += new System.EventHandler(this.btnPCancel_Click);
            // 
            // btnPSave
            // 
            this.btnPSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSave.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnPSave.Location = new System.Drawing.Point(6, 30);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(89, 45);
            this.btnPSave.TabIndex = 4;
            this.btnPSave.Text = "Save";
            this.btnPSave.UseVisualStyleBackColor = true;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // btnPReload
            // 
            this.btnPReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPReload.Location = new System.Drawing.Point(504, 30);
            this.btnPReload.Name = "btnPReload";
            this.btnPReload.Size = new System.Drawing.Size(89, 45);
            this.btnPReload.TabIndex = 3;
            this.btnPReload.Text = "Reload";
            this.btnPReload.UseVisualStyleBackColor = true;
            this.btnPReload.Click += new System.EventHandler(this.btnPReload_Click);
            // 
            // btnPDelete
            // 
            this.btnPDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDelete.Location = new System.Drawing.Point(409, 31);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(89, 45);
            this.btnPDelete.TabIndex = 2;
            this.btnPDelete.Text = "Delete";
            this.btnPDelete.UseVisualStyleBackColor = true;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPUpdate.Location = new System.Drawing.Point(291, 30);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(112, 45);
            this.btnPUpdate.TabIndex = 1;
            this.btnPUpdate.Text = "Update";
            this.btnPUpdate.UseVisualStyleBackColor = true;
            this.btnPUpdate.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // btnPAdd
            // 
            this.btnPAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAdd.Location = new System.Drawing.Point(196, 30);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(89, 45);
            this.btnPAdd.TabIndex = 0;
            this.btnPAdd.Text = "Add";
            this.btnPAdd.UseVisualStyleBackColor = true;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.dgvProduct);
            this.gbProduct.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbProduct.Location = new System.Drawing.Point(514, 8);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(867, 564);
            this.gbProduct.TabIndex = 16;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Display";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(6, 29);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(855, 529);
            this.dgvProduct.TabIndex = 7;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.lblIcon.Location = new System.Drawing.Point(2, 8);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(198, 56);
            this.lblIcon.TabIndex = 15;
            this.lblIcon.Text = "Product";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnPInput
            // 
            this.pnPInput.Location = new System.Drawing.Point(12, 67);
            this.pnPInput.Name = "pnPInput";
            this.pnPInput.Size = new System.Drawing.Size(490, 505);
            this.pnPInput.TabIndex = 18;
            this.pnPInput.Visible = false;
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbP_ViewChoose);
            this.Controls.Add(this.gbTask);
            this.Controls.Add(this.gbProduct);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.pnPInput);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(1384, 694);
            this.Load += new System.EventHandler(this.ucProduct_Load);
            this.gbP_ViewChoose.ResumeLayout(false);
            this.gbP_ViewChoose.PerformLayout();
            this.gbTask.ResumeLayout(false);
            this.gbProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPM_Show;
        private System.Windows.Forms.GroupBox gbP_ViewChoose;
        private System.Windows.Forms.GroupBox gbTask;
        private System.Windows.Forms.Button btnPCancel;
        private System.Windows.Forms.Button btnPSave;
        private System.Windows.Forms.Button btnPReload;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPUpdate;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnPInput;
        private System.Windows.Forms.Label lbP_View;
        private System.Windows.Forms.ComboBox cbP_veiwID;
    }
}
