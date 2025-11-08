namespace PhoneStore.Forms
{
    partial class ucUser
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
            this.pnUserControls = new System.Windows.Forms.Panel();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.lbl_Employee = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnUserControls
            // 
            this.pnUserControls.Location = new System.Drawing.Point(82, 238);
            this.pnUserControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnUserControls.Name = "pnUserControls";
            this.pnUserControls.Size = new System.Drawing.Size(1920, 1050);
            this.pnUserControls.TabIndex = 16;
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.lbl_Customer.Location = new System.Drawing.Point(1362, 118);
            this.lbl_Customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(208, 47);
            this.lbl_Customer.TabIndex = 15;
            this.lbl_Customer.Text = "Customer";
            this.lbl_Customer.Click += new System.EventHandler(this.lbl_Customer_Click);
            // 
            // lbl_Employee
            // 
            this.lbl_Employee.AutoSize = true;
            this.lbl_Employee.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.lbl_Employee.Location = new System.Drawing.Point(754, 118);
            this.lbl_Employee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Employee.Name = "lbl_Employee";
            this.lbl_Employee.Size = new System.Drawing.Size(216, 47);
            this.lbl_Employee.TabIndex = 14;
            this.lbl_Employee.Text = "Employee";
            this.lbl_Employee.Click += new System.EventHandler(this.lbl_Employee_Click);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.lblIcon.Location = new System.Drawing.Point(186, 57);
            this.lblIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(203, 93);
            this.lblIcon.TabIndex = 13;
            this.lblIcon.Text = "User";
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnUserControls);
            this.Controls.Add(this.lbl_Customer);
            this.Controls.Add(this.lbl_Employee);
            this.Controls.Add(this.lblIcon);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(2085, 1345);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnUserControls;
        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.Label lbl_Employee;
        private System.Windows.Forms.Label lblIcon;
    }
}
