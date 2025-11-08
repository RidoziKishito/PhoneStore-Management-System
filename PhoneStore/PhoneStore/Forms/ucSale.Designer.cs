namespace PhoneStore.Forms
{
    partial class ucSale
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
            this.lblIcon = new System.Windows.Forms.Label();
            this.pnUserControls = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnPromotion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.lblIcon.Location = new System.Drawing.Point(6, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(450, 93);
            this.lblIcon.TabIndex = 4;
            this.lblIcon.Text = "Sale Order";
            // 
            // pnUserControls
            // 
            this.pnUserControls.Location = new System.Drawing.Point(3, 92);
            this.pnUserControls.Name = "pnUserControls";
            this.pnUserControls.Size = new System.Drawing.Size(1384, 766);
            this.pnUserControls.TabIndex = 8;
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.btnOrder.Image = global::PhoneStore.Properties.Resources.icons8_order_50;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(1081, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(150, 88);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnPromotion
            // 
            this.btnPromotion.FlatAppearance.BorderSize = 0;
            this.btnPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromotion.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromotion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.btnPromotion.Image = global::PhoneStore.Properties.Resources.icons8_promotion_50;
            this.btnPromotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromotion.Location = new System.Drawing.Point(760, 3);
            this.btnPromotion.Name = "btnPromotion";
            this.btnPromotion.Size = new System.Drawing.Size(221, 88);
            this.btnPromotion.TabIndex = 5;
            this.btnPromotion.Text = "Promotion";
            this.btnPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPromotion.UseVisualStyleBackColor = true;
            this.btnPromotion.Click += new System.EventHandler(this.btnPromotion_Click);
            // 
            // ucSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnUserControls);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPromotion);
            this.Controls.Add(this.lblIcon);
            this.Name = "ucSale";
            this.Size = new System.Drawing.Size(1390, 861);
            this.Load += new System.EventHandler(this.ucSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Button btnPromotion;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel pnUserControls;
    }
}
