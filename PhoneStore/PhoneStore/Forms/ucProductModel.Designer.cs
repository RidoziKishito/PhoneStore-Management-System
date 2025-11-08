namespace PhoneStore.Forms
{
    partial class ucProductModel
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
            this.lblIcon = new System.Windows.Forms.Label();
            this.dgvProductModel = new System.Windows.Forms.DataGridView();
            this.gbProductModel = new System.Windows.Forms.GroupBox();
            this.llblAddPicture = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbTask = new System.Windows.Forms.GroupBox();
            this.btnPMCancel = new System.Windows.Forms.Button();
            this.btnPMSave = new System.Windows.Forms.Button();
            this.btnPMReload = new System.Windows.Forms.Button();
            this.btnPMDelete = new System.Windows.Forms.Button();
            this.btnPMUpdate = new System.Windows.Forms.Button();
            this.btnPMAdd = new System.Windows.Forms.Button();
            this.gbPM_ViewChoose = new System.Windows.Forms.GroupBox();
            this.lbPM_View = new System.Windows.Forms.Label();
            this.cbPM_veiwID = new System.Windows.Forms.ComboBox();
            this.btnPM_Show = new System.Windows.Forms.Button();
            this.pnPMInput = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductModel)).BeginInit();
            this.gbProductModel.SuspendLayout();
            this.gbTask.SuspendLayout();
            this.gbPM_ViewChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.lblIcon.Location = new System.Drawing.Point(3, 9);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(355, 56);
            this.lblIcon.TabIndex = 6;
            this.lblIcon.Text = "Product Model\r\n";
            this.lblIcon.Click += new System.EventHandler(this.lblIcon_Click);
            // 
            // dgvProductModel
            // 
            this.dgvProductModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductModel.Location = new System.Drawing.Point(6, 29);
            this.dgvProductModel.Name = "dgvProductModel";
            this.dgvProductModel.RowHeadersWidth = 51;
            this.dgvProductModel.RowTemplate.Height = 24;
            this.dgvProductModel.Size = new System.Drawing.Size(747, 494);
            this.dgvProductModel.TabIndex = 7;
            this.dgvProductModel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductModel_CellClick);
            // 
            // gbProductModel
            // 
            this.gbProductModel.Controls.Add(this.llblAddPicture);
            this.gbProductModel.Controls.Add(this.dgvProductModel);
            this.gbProductModel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbProductModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbProductModel.Location = new System.Drawing.Point(518, 9);
            this.gbProductModel.Name = "gbProductModel";
            this.gbProductModel.Size = new System.Drawing.Size(759, 564);
            this.gbProductModel.TabIndex = 8;
            this.gbProductModel.TabStop = false;
            this.gbProductModel.Text = "Display";
            // 
            // llblAddPicture
            // 
            this.llblAddPicture.AutoSize = true;
            this.llblAddPicture.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblAddPicture.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.llblAddPicture.Location = new System.Drawing.Point(594, 535);
            this.llblAddPicture.Name = "llblAddPicture";
            this.llblAddPicture.Size = new System.Drawing.Size(117, 16);
            this.llblAddPicture.TabIndex = 8;
            this.llblAddPicture.TabStop = true;
            this.llblAddPicture.Text = "Add a picture >>";
            this.llblAddPicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAddPicture_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.btnPMCancel);
            this.gbTask.Controls.Add(this.btnPMSave);
            this.gbTask.Controls.Add(this.btnPMReload);
            this.gbTask.Controls.Add(this.btnPMDelete);
            this.gbTask.Controls.Add(this.btnPMUpdate);
            this.gbTask.Controls.Add(this.btnPMAdd);
            this.gbTask.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbTask.Location = new System.Drawing.Point(658, 579);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(619, 101);
            this.gbTask.TabIndex = 12;
            this.gbTask.TabStop = false;
            this.gbTask.Text = "Tasks";
            // 
            // btnPMCancel
            // 
            this.btnPMCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMCancel.Location = new System.Drawing.Point(102, 38);
            this.btnPMCancel.Name = "btnPMCancel";
            this.btnPMCancel.Size = new System.Drawing.Size(88, 45);
            this.btnPMCancel.TabIndex = 5;
            this.btnPMCancel.Text = "Cancel";
            this.btnPMCancel.UseVisualStyleBackColor = true;
            this.btnPMCancel.Click += new System.EventHandler(this.btnPMCancel_Click);
            // 
            // btnPMSave
            // 
            this.btnPMSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMSave.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnPMSave.Location = new System.Drawing.Point(8, 38);
            this.btnPMSave.Name = "btnPMSave";
            this.btnPMSave.Size = new System.Drawing.Size(88, 45);
            this.btnPMSave.TabIndex = 4;
            this.btnPMSave.Text = "Save";
            this.btnPMSave.UseVisualStyleBackColor = true;
            this.btnPMSave.Click += new System.EventHandler(this.btnPMSave_Click);
            // 
            // btnPMReload
            // 
            this.btnPMReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPMReload.Location = new System.Drawing.Point(525, 38);
            this.btnPMReload.Name = "btnPMReload";
            this.btnPMReload.Size = new System.Drawing.Size(88, 45);
            this.btnPMReload.TabIndex = 3;
            this.btnPMReload.Text = "Reload";
            this.btnPMReload.UseVisualStyleBackColor = true;
            this.btnPMReload.Click += new System.EventHandler(this.btnPMReload_Click);
            // 
            // btnPMDelete
            // 
            this.btnPMDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMDelete.Location = new System.Drawing.Point(407, 38);
            this.btnPMDelete.Name = "btnPMDelete";
            this.btnPMDelete.Size = new System.Drawing.Size(112, 45);
            this.btnPMDelete.TabIndex = 2;
            this.btnPMDelete.Text = "Delete";
            this.btnPMDelete.UseVisualStyleBackColor = true;
            this.btnPMDelete.Click += new System.EventHandler(this.btnPMDelete_Click);
            // 
            // btnPMUpdate
            // 
            this.btnPMUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMUpdate.Location = new System.Drawing.Point(290, 38);
            this.btnPMUpdate.Name = "btnPMUpdate";
            this.btnPMUpdate.Size = new System.Drawing.Size(111, 45);
            this.btnPMUpdate.TabIndex = 1;
            this.btnPMUpdate.Text = "Update";
            this.btnPMUpdate.UseVisualStyleBackColor = true;
            this.btnPMUpdate.Click += new System.EventHandler(this.btnPMUpdate_Click);
            // 
            // btnPMAdd
            // 
            this.btnPMAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMAdd.Location = new System.Drawing.Point(196, 38);
            this.btnPMAdd.Name = "btnPMAdd";
            this.btnPMAdd.Size = new System.Drawing.Size(88, 45);
            this.btnPMAdd.TabIndex = 0;
            this.btnPMAdd.Text = "Add";
            this.btnPMAdd.UseVisualStyleBackColor = true;
            this.btnPMAdd.Click += new System.EventHandler(this.btnPMAdd_Click);
            // 
            // gbPM_ViewChoose
            // 
            this.gbPM_ViewChoose.Controls.Add(this.lbPM_View);
            this.gbPM_ViewChoose.Controls.Add(this.cbPM_veiwID);
            this.gbPM_ViewChoose.Controls.Add(this.btnPM_Show);
            this.gbPM_ViewChoose.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPM_ViewChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbPM_ViewChoose.Location = new System.Drawing.Point(13, 579);
            this.gbPM_ViewChoose.Name = "gbPM_ViewChoose";
            this.gbPM_ViewChoose.Size = new System.Drawing.Size(639, 101);
            this.gbPM_ViewChoose.TabIndex = 6;
            this.gbPM_ViewChoose.TabStop = false;
            this.gbPM_ViewChoose.Text = "View listed price";
            // 
            // lbPM_View
            // 
            this.lbPM_View.AutoSize = true;
            this.lbPM_View.Location = new System.Drawing.Point(14, 49);
            this.lbPM_View.Name = "lbPM_View";
            this.lbPM_View.Size = new System.Drawing.Size(101, 22);
            this.lbPM_View.TabIndex = 4;
            this.lbPM_View.Text = "Product ID";
            // 
            // cbPM_veiwID
            // 
            this.cbPM_veiwID.FormattingEnabled = true;
            this.cbPM_veiwID.Location = new System.Drawing.Point(121, 45);
            this.cbPM_veiwID.Name = "cbPM_veiwID";
            this.cbPM_veiwID.Size = new System.Drawing.Size(428, 30);
            this.cbPM_veiwID.TabIndex = 3;
            // 
            // btnPM_Show
            // 
            this.btnPM_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPM_Show.Location = new System.Drawing.Point(555, 45);
            this.btnPM_Show.Name = "btnPM_Show";
            this.btnPM_Show.Size = new System.Drawing.Size(78, 30);
            this.btnPM_Show.TabIndex = 1;
            this.btnPM_Show.Text = "Show";
            this.btnPM_Show.UseVisualStyleBackColor = true;
            this.btnPM_Show.Click += new System.EventHandler(this.btnPM_Show_Click);
            // 
            // pnPMInput
            // 
            this.pnPMInput.Location = new System.Drawing.Point(13, 68);
            this.pnPMInput.Name = "pnPMInput";
            this.pnPMInput.Size = new System.Drawing.Size(490, 505);
            this.pnPMInput.TabIndex = 13;
            this.pnPMInput.Visible = false;
            // 
            // ucProductModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnPMInput);
            this.Controls.Add(this.gbPM_ViewChoose);
            this.Controls.Add(this.gbTask);
            this.Controls.Add(this.gbProductModel);
            this.Controls.Add(this.lblIcon);
            this.Name = "ucProductModel";
            this.Size = new System.Drawing.Size(1280, 698);
            this.Load += new System.EventHandler(this.ucProductModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductModel)).EndInit();
            this.gbProductModel.ResumeLayout(false);
            this.gbProductModel.PerformLayout();
            this.gbTask.ResumeLayout(false);
            this.gbPM_ViewChoose.ResumeLayout(false);
            this.gbPM_ViewChoose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.DataGridView dgvProductModel;
        private System.Windows.Forms.GroupBox gbProductModel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.GroupBox gbTask;
        private System.Windows.Forms.Button btnPMCancel;
        private System.Windows.Forms.Button btnPMSave;
        private System.Windows.Forms.Button btnPMReload;
        private System.Windows.Forms.Button btnPMDelete;
        private System.Windows.Forms.Button btnPMUpdate;
        private System.Windows.Forms.Button btnPMAdd;
        private System.Windows.Forms.GroupBox gbPM_ViewChoose;
        private System.Windows.Forms.Button btnPM_Show;
        private System.Windows.Forms.Label lbPM_View;
        private System.Windows.Forms.ComboBox cbPM_veiwID;
        private System.Windows.Forms.Panel pnPMInput;
        private System.Windows.Forms.LinkLabel llblAddPicture;
    }
}
