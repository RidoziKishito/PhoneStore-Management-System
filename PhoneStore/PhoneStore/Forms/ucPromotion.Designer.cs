namespace PhoneStore.Forms
{
    partial class ucPromotion
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
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dgvPromotions = new System.Windows.Forms.DataGridView();
            this.gbPromotionInfo = new System.Windows.Forms.GroupBox();
            this.btnDeletePromotion = new System.Windows.Forms.Button();
            this.btnAddPromotion = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.nudPercentage = new System.Windows.Forms.NumericUpDown();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.cbPromotionID = new System.Windows.Forms.ComboBox();
            this.lblCheckPromotion = new System.Windows.Forms.Label();
            this.gpPromotionDisplay = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotions)).BeginInit();
            this.gbPromotionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentage)).BeginInit();
            this.gpPromotionDisplay.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(38, 56);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(100, 22);
            this.lblCondition.TabIndex = 6;
            this.lblCondition.Text = "Condition:";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(19, 120);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(119, 22);
            this.lblPercentage.TabIndex = 7;
            this.lblPercentage.Text = "Percentage:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(38, 182);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(99, 22);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(43, 248);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(94, 22);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "End Date:";
            // 
            // dgvPromotions
            // 
            this.dgvPromotions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromotions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromotions.Location = new System.Drawing.Point(6, 29);
            this.dgvPromotions.Name = "dgvPromotions";
            this.dgvPromotions.RowHeadersWidth = 51;
            this.dgvPromotions.RowTemplate.Height = 24;
            this.dgvPromotions.Size = new System.Drawing.Size(855, 687);
            this.dgvPromotions.TabIndex = 10;
            // 
            // gbPromotionInfo
            // 
            this.gbPromotionInfo.Controls.Add(this.btnReload);
            this.gbPromotionInfo.Controls.Add(this.btnDeletePromotion);
            this.gbPromotionInfo.Controls.Add(this.btnAddPromotion);
            this.gbPromotionInfo.Controls.Add(this.dtpEnd);
            this.gbPromotionInfo.Controls.Add(this.dtpStart);
            this.gbPromotionInfo.Controls.Add(this.nudPercentage);
            this.gbPromotionInfo.Controls.Add(this.txtCondition);
            this.gbPromotionInfo.Controls.Add(this.lblStartDate);
            this.gbPromotionInfo.Controls.Add(this.lblEndDate);
            this.gbPromotionInfo.Controls.Add(this.lblPercentage);
            this.gbPromotionInfo.Controls.Add(this.lblCondition);
            this.gbPromotionInfo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbPromotionInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gbPromotionInfo.Location = new System.Drawing.Point(9, 6);
            this.gbPromotionInfo.Name = "gbPromotionInfo";
            this.gbPromotionInfo.Size = new System.Drawing.Size(499, 338);
            this.gbPromotionInfo.TabIndex = 11;
            this.gbPromotionInfo.TabStop = false;
            this.gbPromotionInfo.Text = "Promotion Information";
            // 
            // btnDeletePromotion
            // 
            this.btnDeletePromotion.Location = new System.Drawing.Point(199, 284);
            this.btnDeletePromotion.Name = "btnDeletePromotion";
            this.btnDeletePromotion.Size = new System.Drawing.Size(139, 40);
            this.btnDeletePromotion.TabIndex = 15;
            this.btnDeletePromotion.Text = "Delete";
            this.btnDeletePromotion.UseVisualStyleBackColor = true;
            this.btnDeletePromotion.Click += new System.EventHandler(this.btnDeletePromotion_Click);
            // 
            // btnAddPromotion
            // 
            this.btnAddPromotion.Location = new System.Drawing.Point(54, 284);
            this.btnAddPromotion.Name = "btnAddPromotion";
            this.btnAddPromotion.Size = new System.Drawing.Size(139, 40);
            this.btnAddPromotion.TabIndex = 14;
            this.btnAddPromotion.Text = "Add";
            this.btnAddPromotion.UseVisualStyleBackColor = true;
            this.btnAddPromotion.Click += new System.EventHandler(this.btnAddPromotion_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(144, 240);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(339, 30);
            this.dtpEnd.TabIndex = 13;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(144, 176);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(339, 30);
            this.dtpStart.TabIndex = 12;
            // 
            // nudPercentage
            // 
            this.nudPercentage.Location = new System.Drawing.Point(144, 112);
            this.nudPercentage.Name = "nudPercentage";
            this.nudPercentage.Size = new System.Drawing.Size(121, 30);
            this.nudPercentage.TabIndex = 11;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(144, 48);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(339, 30);
            this.txtCondition.TabIndex = 10;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(338, 81);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(145, 30);
            this.btnShow.TabIndex = 18;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cbPromotionID
            // 
            this.cbPromotionID.FormattingEnabled = true;
            this.cbPromotionID.Location = new System.Drawing.Point(23, 82);
            this.cbPromotionID.Name = "cbPromotionID";
            this.cbPromotionID.Size = new System.Drawing.Size(300, 30);
            this.cbPromotionID.TabIndex = 17;
            // 
            // lblCheckPromotion
            // 
            this.lblCheckPromotion.AutoSize = true;
            this.lblCheckPromotion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckPromotion.Location = new System.Drawing.Point(19, 44);
            this.lblCheckPromotion.Name = "lblCheckPromotion";
            this.lblCheckPromotion.Size = new System.Drawing.Size(237, 21);
            this.lblCheckPromotion.TabIndex = 16;
            this.lblCheckPromotion.Text = "Sale orders on promotion:";
            // 
            // gpPromotionDisplay
            // 
            this.gpPromotionDisplay.Controls.Add(this.dgvPromotions);
            this.gpPromotionDisplay.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.gpPromotionDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gpPromotionDisplay.Location = new System.Drawing.Point(514, 6);
            this.gpPromotionDisplay.Name = "gpPromotionDisplay";
            this.gpPromotionDisplay.Size = new System.Drawing.Size(867, 722);
            this.gpPromotionDisplay.TabIndex = 12;
            this.gpPromotionDisplay.TabStop = false;
            this.gpPromotionDisplay.Text = "Promotion Display";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPromotionID);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.lblCheckPromotion);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 126);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promotion Information";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(344, 284);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(139, 40);
            this.btnReload.TabIndex = 16;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // ucPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpPromotionDisplay);
            this.Controls.Add(this.gbPromotionInfo);
            this.Name = "ucPromotion";
            this.Size = new System.Drawing.Size(1384, 766);
            this.Load += new System.EventHandler(this.ucPromotion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotions)).EndInit();
            this.gbPromotionInfo.ResumeLayout(false);
            this.gbPromotionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentage)).EndInit();
            this.gpPromotionDisplay.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DataGridView dgvPromotions;
        private System.Windows.Forms.GroupBox gbPromotionInfo;
        private System.Windows.Forms.GroupBox gpPromotionDisplay;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.NumericUpDown nudPercentage;
        private System.Windows.Forms.Button btnDeletePromotion;
        private System.Windows.Forms.Button btnAddPromotion;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cbPromotionID;
        private System.Windows.Forms.Label lblCheckPromotion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReload;
    }
}
