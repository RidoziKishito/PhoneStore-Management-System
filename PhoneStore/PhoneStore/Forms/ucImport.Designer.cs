namespace PhoneStore.Forms
{
    partial class ucImport
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
            this.gbView = new System.Windows.Forms.GroupBox();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.gbTask = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblIcon = new System.Windows.Forms.Label();
            this.gbViewChoose = new System.Windows.Forms.GroupBox();
            this.cbView = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbNaviagtion = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.gbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.gbTask.SuspendLayout();
            this.gbViewChoose.SuspendLayout();
            this.gbNaviagtion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbView
            // 
            this.gbView.Controls.Add(this.dgvDisplay);
            this.gbView.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbView.Location = new System.Drawing.Point(535, 22);
            this.gbView.Name = "gbView";
            this.gbView.Size = new System.Drawing.Size(848, 731);
            this.gbView.TabIndex = 0;
            this.gbView.TabStop = false;
            this.gbView.Text = "Display";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(6, 29);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowHeadersWidth = 51;
            this.dgvDisplay.RowTemplate.Height = 24;
            this.dgvDisplay.Size = new System.Drawing.Size(830, 696);
            this.dgvDisplay.TabIndex = 0;
            this.dgvDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellClick);
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.btnCancel);
            this.gbTask.Controls.Add(this.btnSave);
            this.gbTask.Controls.Add(this.btnReload);
            this.gbTask.Controls.Add(this.btnDelete);
            this.gbTask.Controls.Add(this.btnUpdate);
            this.gbTask.Controls.Add(this.btnAdd);
            this.gbTask.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbTask.Location = new System.Drawing.Point(784, 759);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(599, 81);
            this.gbTask.TabIndex = 1;
            this.gbTask.TabStop = false;
            this.gbTask.Text = "Tasks";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(101, 29);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnSave.Location = new System.Drawing.Point(6, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReload.Location = new System.Drawing.Point(504, 29);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(89, 45);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(409, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(291, 29);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(196, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.lblIcon.Location = new System.Drawing.Point(25, 13);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(493, 56);
            this.lblIcon.TabIndex = 3;
            this.lblIcon.Text = "Import Management\r\n";
            // 
            // gbViewChoose
            // 
            this.gbViewChoose.Controls.Add(this.cbView);
            this.gbViewChoose.Controls.Add(this.btnShow);
            this.gbViewChoose.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbViewChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbViewChoose.Location = new System.Drawing.Point(315, 759);
            this.gbViewChoose.Name = "gbViewChoose";
            this.gbViewChoose.Size = new System.Drawing.Size(463, 81);
            this.gbViewChoose.TabIndex = 4;
            this.gbViewChoose.TabStop = false;
            this.gbViewChoose.Text = "View";
            // 
            // cbView
            // 
            this.cbView.FormattingEnabled = true;
            this.cbView.Location = new System.Drawing.Point(6, 37);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(375, 30);
            this.cbView.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(387, 30);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(70, 45);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // gbNaviagtion
            // 
            this.gbNaviagtion.Controls.Add(this.btnImport);
            this.gbNaviagtion.Controls.Add(this.btnSupplier);
            this.gbNaviagtion.Controls.Add(this.btnBack);
            this.gbNaviagtion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNaviagtion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbNaviagtion.Location = new System.Drawing.Point(9, 759);
            this.gbNaviagtion.Name = "gbNaviagtion";
            this.gbNaviagtion.Size = new System.Drawing.Size(300, 81);
            this.gbNaviagtion.TabIndex = 6;
            this.gbNaviagtion.TabStop = false;
            this.gbNaviagtion.Text = "Navigation";
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(6, 30);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(87, 45);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Location = new System.Drawing.Point(99, 30);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(109, 45);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(214, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 45);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Main";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(9, 81);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(520, 672);
            this.pnMain.TabIndex = 7;
            // 
            // ucImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.gbNaviagtion);
            this.Controls.Add(this.gbViewChoose);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.gbTask);
            this.Controls.Add(this.gbView);
            this.Name = "ucImport";
            this.Size = new System.Drawing.Size(1390, 861);
            this.Load += new System.EventHandler(this.ucImport_Load);
            this.gbView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.gbTask.ResumeLayout(false);
            this.gbViewChoose.ResumeLayout(false);
            this.gbNaviagtion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbView;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.GroupBox gbTask;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.GroupBox gbViewChoose;
        private System.Windows.Forms.ComboBox cbView;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox gbNaviagtion;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
