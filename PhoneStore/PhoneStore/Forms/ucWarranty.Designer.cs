namespace PhoneStore.Forms
{
    partial class ucWarranty
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
            this.pnWarrantyInput = new System.Windows.Forms.Panel();
            this.gbTask = new System.Windows.Forms.GroupBox();
            this.btnWarrCancel = new System.Windows.Forms.Button();
            this.btnWarrSave = new System.Windows.Forms.Button();
            this.btnWarrReload = new System.Windows.Forms.Button();
            this.btnWarrDelete = new System.Windows.Forms.Button();
            this.btnWarrAdd = new System.Windows.Forms.Button();
            this.gbWarranty = new System.Windows.Forms.GroupBox();
            this.dgvWarranty = new System.Windows.Forms.DataGridView();
            this.lblIcon = new System.Windows.Forms.Label();
            this.gbTask.SuspendLayout();
            this.gbWarranty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarranty)).BeginInit();
            this.SuspendLayout();
            // 
            // pnWarrantyInput
            // 
            this.pnWarrantyInput.Location = new System.Drawing.Point(3, 62);
            this.pnWarrantyInput.Name = "pnWarrantyInput";
            this.pnWarrantyInput.Size = new System.Drawing.Size(521, 619);
            this.pnWarrantyInput.TabIndex = 22;
            this.pnWarrantyInput.Visible = false;
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.btnWarrCancel);
            this.gbTask.Controls.Add(this.btnWarrSave);
            this.gbTask.Controls.Add(this.btnWarrReload);
            this.gbTask.Controls.Add(this.btnWarrDelete);
            this.gbTask.Controls.Add(this.btnWarrAdd);
            this.gbTask.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbTask.Location = new System.Drawing.Point(530, 601);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(484, 81);
            this.gbTask.TabIndex = 21;
            this.gbTask.TabStop = false;
            this.gbTask.Text = "Tasks";
            // 
            // btnWarrCancel
            // 
            this.btnWarrCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarrCancel.Location = new System.Drawing.Point(101, 29);
            this.btnWarrCancel.Name = "btnWarrCancel";
            this.btnWarrCancel.Size = new System.Drawing.Size(89, 45);
            this.btnWarrCancel.TabIndex = 5;
            this.btnWarrCancel.Text = "Cancel";
            this.btnWarrCancel.UseVisualStyleBackColor = true;
            this.btnWarrCancel.Click += new System.EventHandler(this.btnWarrCancel_Click);
            // 
            // btnWarrSave
            // 
            this.btnWarrSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarrSave.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnWarrSave.Location = new System.Drawing.Point(6, 29);
            this.btnWarrSave.Name = "btnWarrSave";
            this.btnWarrSave.Size = new System.Drawing.Size(89, 45);
            this.btnWarrSave.TabIndex = 4;
            this.btnWarrSave.Text = "Save";
            this.btnWarrSave.UseVisualStyleBackColor = true;
            this.btnWarrSave.Click += new System.EventHandler(this.btnWarrSave_Click);
            // 
            // btnWarrReload
            // 
            this.btnWarrReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarrReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnWarrReload.Location = new System.Drawing.Point(386, 29);
            this.btnWarrReload.Name = "btnWarrReload";
            this.btnWarrReload.Size = new System.Drawing.Size(89, 45);
            this.btnWarrReload.TabIndex = 3;
            this.btnWarrReload.Text = "Reload";
            this.btnWarrReload.UseVisualStyleBackColor = true;
            this.btnWarrReload.Click += new System.EventHandler(this.btnWarrReload_Click);
            // 
            // btnWarrDelete
            // 
            this.btnWarrDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarrDelete.Location = new System.Drawing.Point(291, 29);
            this.btnWarrDelete.Name = "btnWarrDelete";
            this.btnWarrDelete.Size = new System.Drawing.Size(89, 45);
            this.btnWarrDelete.TabIndex = 2;
            this.btnWarrDelete.Text = "Delete";
            this.btnWarrDelete.UseVisualStyleBackColor = true;
            this.btnWarrDelete.Click += new System.EventHandler(this.btnWarrDelete_Click);
            // 
            // btnWarrAdd
            // 
            this.btnWarrAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarrAdd.Location = new System.Drawing.Point(196, 29);
            this.btnWarrAdd.Name = "btnWarrAdd";
            this.btnWarrAdd.Size = new System.Drawing.Size(89, 45);
            this.btnWarrAdd.TabIndex = 0;
            this.btnWarrAdd.Text = "Add";
            this.btnWarrAdd.UseVisualStyleBackColor = true;
            this.btnWarrAdd.Click += new System.EventHandler(this.btnWarrAdd_Click);
            // 
            // gbWarranty
            // 
            this.gbWarranty.Controls.Add(this.dgvWarranty);
            this.gbWarranty.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbWarranty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbWarranty.Location = new System.Drawing.Point(530, 3);
            this.gbWarranty.Name = "gbWarranty";
            this.gbWarranty.Size = new System.Drawing.Size(851, 598);
            this.gbWarranty.TabIndex = 20;
            this.gbWarranty.TabStop = false;
            this.gbWarranty.Text = "Display";
            // 
            // dgvWarranty
            // 
            this.dgvWarranty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarranty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarranty.Location = new System.Drawing.Point(6, 29);
            this.dgvWarranty.Name = "dgvWarranty";
            this.dgvWarranty.RowHeadersWidth = 51;
            this.dgvWarranty.RowTemplate.Height = 24;
            this.dgvWarranty.Size = new System.Drawing.Size(839, 563);
            this.dgvWarranty.TabIndex = 7;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.lblIcon.Location = new System.Drawing.Point(24, 3);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(227, 56);
            this.lblIcon.TabIndex = 19;
            this.lblIcon.Text = "Warranty";
            // 
            // ucWarranty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnWarrantyInput);
            this.Controls.Add(this.gbTask);
            this.Controls.Add(this.gbWarranty);
            this.Controls.Add(this.lblIcon);
            this.Name = "ucWarranty";
            this.Size = new System.Drawing.Size(1384, 694);
            this.gbTask.ResumeLayout(false);
            this.gbWarranty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarranty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnWarrantyInput;
        private System.Windows.Forms.GroupBox gbTask;
        private System.Windows.Forms.Button btnWarrCancel;
        private System.Windows.Forms.Button btnWarrSave;
        private System.Windows.Forms.Button btnWarrReload;
        private System.Windows.Forms.Button btnWarrDelete;
        private System.Windows.Forms.Button btnWarrAdd;
        private System.Windows.Forms.GroupBox gbWarranty;
        private System.Windows.Forms.DataGridView dgvWarranty;
        private System.Windows.Forms.Label lblIcon;
    }
}
