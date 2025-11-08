namespace PhoneStore.Forms
{
    partial class ucTechnical_Spec
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
            this.pnTSInput = new System.Windows.Forms.Panel();
            this.gbTask = new System.Windows.Forms.GroupBox();
            this.btnTSCancel = new System.Windows.Forms.Button();
            this.btnTSSave = new System.Windows.Forms.Button();
            this.btnTSReload = new System.Windows.Forms.Button();
            this.btnTSDelete = new System.Windows.Forms.Button();
            this.btnTSUpdate = new System.Windows.Forms.Button();
            this.btnTSAdd = new System.Windows.Forms.Button();
            this.gbProductModel = new System.Windows.Forms.GroupBox();
            this.dgvTechSpecs = new System.Windows.Forms.DataGridView();
            this.lblIcon = new System.Windows.Forms.Label();
            this.gbTask.SuspendLayout();
            this.gbProductModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechSpecs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTSInput
            // 
            this.pnTSInput.Location = new System.Drawing.Point(19, 94);
            this.pnTSInput.Name = "pnTSInput";
            this.pnTSInput.Size = new System.Drawing.Size(490, 567);
            this.pnTSInput.TabIndex = 18;
            this.pnTSInput.Visible = false;
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.btnTSCancel);
            this.gbTask.Controls.Add(this.btnTSSave);
            this.gbTask.Controls.Add(this.btnTSReload);
            this.gbTask.Controls.Add(this.btnTSDelete);
            this.gbTask.Controls.Add(this.btnTSUpdate);
            this.gbTask.Controls.Add(this.btnTSAdd);
            this.gbTask.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbTask.Location = new System.Drawing.Point(523, 587);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(858, 87);
            this.gbTask.TabIndex = 17;
            this.gbTask.TabStop = false;
            this.gbTask.Text = "Tasks";
            // 
            // btnTSCancel
            // 
            this.btnTSCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTSCancel.Location = new System.Drawing.Point(150, 29);
            this.btnTSCancel.Name = "btnTSCancel";
            this.btnTSCancel.Size = new System.Drawing.Size(114, 45);
            this.btnTSCancel.TabIndex = 5;
            this.btnTSCancel.Text = "Cancel";
            this.btnTSCancel.UseVisualStyleBackColor = true;
            this.btnTSCancel.Click += new System.EventHandler(this.btnTSCancel_Click);
            // 
            // btnTSSave
            // 
            this.btnTSSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTSSave.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnTSSave.Location = new System.Drawing.Point(9, 29);
            this.btnTSSave.Name = "btnTSSave";
            this.btnTSSave.Size = new System.Drawing.Size(114, 45);
            this.btnTSSave.TabIndex = 4;
            this.btnTSSave.Text = "Save";
            this.btnTSSave.UseVisualStyleBackColor = true;
            this.btnTSSave.Click += new System.EventHandler(this.btnTSSave_Click);
            // 
            // btnTSReload
            // 
            this.btnTSReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTSReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTSReload.Location = new System.Drawing.Point(737, 29);
            this.btnTSReload.Name = "btnTSReload";
            this.btnTSReload.Size = new System.Drawing.Size(114, 45);
            this.btnTSReload.TabIndex = 3;
            this.btnTSReload.Text = "Reload";
            this.btnTSReload.UseVisualStyleBackColor = true;
            this.btnTSReload.Click += new System.EventHandler(this.btnPMReload_Click);
            // 
            // btnTSDelete
            // 
            this.btnTSDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTSDelete.Location = new System.Drawing.Point(596, 29);
            this.btnTSDelete.Name = "btnTSDelete";
            this.btnTSDelete.Size = new System.Drawing.Size(114, 45);
            this.btnTSDelete.TabIndex = 2;
            this.btnTSDelete.Text = "Delete";
            this.btnTSDelete.UseVisualStyleBackColor = true;
            this.btnTSDelete.Click += new System.EventHandler(this.btnTSDelete_Click);
            // 
            // btnTSUpdate
            // 
            this.btnTSUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTSUpdate.Location = new System.Drawing.Point(432, 29);
            this.btnTSUpdate.Name = "btnTSUpdate";
            this.btnTSUpdate.Size = new System.Drawing.Size(137, 45);
            this.btnTSUpdate.TabIndex = 1;
            this.btnTSUpdate.Text = "Update";
            this.btnTSUpdate.UseVisualStyleBackColor = true;
            this.btnTSUpdate.Click += new System.EventHandler(this.btnTSUpdate_Click);
            // 
            // btnTSAdd
            // 
            this.btnTSAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTSAdd.Location = new System.Drawing.Point(291, 29);
            this.btnTSAdd.Name = "btnTSAdd";
            this.btnTSAdd.Size = new System.Drawing.Size(114, 45);
            this.btnTSAdd.TabIndex = 0;
            this.btnTSAdd.Text = "Add";
            this.btnTSAdd.UseVisualStyleBackColor = true;
            this.btnTSAdd.Click += new System.EventHandler(this.btnTSAdd_Click);
            // 
            // gbProductModel
            // 
            this.gbProductModel.Controls.Add(this.dgvTechSpecs);
            this.gbProductModel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbProductModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbProductModel.Location = new System.Drawing.Point(523, 17);
            this.gbProductModel.Name = "gbProductModel";
            this.gbProductModel.Size = new System.Drawing.Size(858, 564);
            this.gbProductModel.TabIndex = 16;
            this.gbProductModel.TabStop = false;
            this.gbProductModel.Text = "Display";
            // 
            // dgvTechSpecs
            // 
            this.dgvTechSpecs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTechSpecs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechSpecs.Location = new System.Drawing.Point(6, 29);
            this.dgvTechSpecs.Name = "dgvTechSpecs";
            this.dgvTechSpecs.RowHeadersWidth = 51;
            this.dgvTechSpecs.RowTemplate.Height = 24;
            this.dgvTechSpecs.Size = new System.Drawing.Size(846, 529);
            this.dgvTechSpecs.TabIndex = 7;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.lblIcon.Location = new System.Drawing.Point(10, 27);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(507, 49);
            this.lblIcon.TabIndex = 15;
            this.lblIcon.Text = "Technical Specification";
            // 
            // ucTechnical_Spec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnTSInput);
            this.Controls.Add(this.gbTask);
            this.Controls.Add(this.gbProductModel);
            this.Controls.Add(this.lblIcon);
            this.Name = "ucTechnical_Spec";
            this.Size = new System.Drawing.Size(1384, 694);
            this.gbTask.ResumeLayout(false);
            this.gbProductModel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechSpecs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTSInput;
        private System.Windows.Forms.GroupBox gbTask;
        private System.Windows.Forms.Button btnTSCancel;
        private System.Windows.Forms.Button btnTSSave;
        private System.Windows.Forms.Button btnTSReload;
        private System.Windows.Forms.Button btnTSDelete;
        private System.Windows.Forms.Button btnTSUpdate;
        private System.Windows.Forms.Button btnTSAdd;
        private System.Windows.Forms.GroupBox gbProductModel;
        private System.Windows.Forms.DataGridView dgvTechSpecs;
        private System.Windows.Forms.Label lblIcon;
    }
}
