namespace PhoneStore
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblIcon = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pbYellowBell = new System.Windows.Forms.PictureBox();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pnUserControls = new System.Windows.Forms.Panel();
            this.timerNoti = new System.Windows.Forms.Timer(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellowBell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.pnLeft.Controls.Add(this.lblUser);
            this.pnLeft.Controls.Add(this.btnMain);
            this.pnLeft.Controls.Add(this.btnSale);
            this.pnLeft.Controls.Add(this.btnPeople);
            this.pnLeft.Controls.Add(this.btnProduct);
            this.pnLeft.Controls.Add(this.btnImport);
            this.pnLeft.Controls.Add(this.lblIcon);
            this.pnLeft.Controls.Add(this.pbIcon);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(210, 900);
            this.pnLeft.TabIndex = 0;
            // 
            // btnMain
            // 
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.btnMain.Image = global::PhoneStore.Properties.Resources.icons8_dashboard_501;
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(0, 125);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(240, 88);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnSale
            // 
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.btnSale.Image = global::PhoneStore.Properties.Resources.icons8_sale_48;
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(0, 501);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(230, 88);
            this.btnSale.TabIndex = 5;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.btnPeople.Image = global::PhoneStore.Properties.Resources.icons8_customer_48;
            this.btnPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeople.Location = new System.Drawing.Point(0, 407);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(230, 88);
            this.btnPeople.TabIndex = 4;
            this.btnPeople.Text = "Users";
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.btnProduct.Image = global::PhoneStore.Properties.Resources.icons8_product_48;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 313);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(266, 88);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnImport
            // 
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.btnImport.Image = global::PhoneStore.Properties.Resources.icons8_warehouse_48__1_;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(0, 219);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(257, 88);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.lblIcon.Location = new System.Drawing.Point(96, 3);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(97, 78);
            this.lblIcon.TabIndex = 1;
            this.lblIcon.Text = "FPT\r\nShop\r\n";
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::PhoneStore.Properties.Resources.icons8_store_64;
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(90, 89);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.pnTop.Controls.Add(this.pbYellowBell);
            this.pnTop.Controls.Add(this.pbLogout);
            this.pnTop.Controls.Add(this.pbClose);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(210, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1390, 39);
            this.pnTop.TabIndex = 1;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseDown);
            this.pnTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseMove);
            this.pnTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseUp);
            // 
            // pbYellowBell
            // 
            this.pbYellowBell.Image = global::PhoneStore.Properties.Resources.icons8_notification_64_yellowbell;
            this.pbYellowBell.Location = new System.Drawing.Point(1252, 3);
            this.pbYellowBell.Name = "pbYellowBell";
            this.pbYellowBell.Size = new System.Drawing.Size(39, 36);
            this.pbYellowBell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbYellowBell.TabIndex = 5;
            this.pbYellowBell.TabStop = false;
            this.pbYellowBell.Click += new System.EventHandler(this.pbYellowBell_Click);
            // 
            // pbLogout
            // 
            this.pbLogout.Image = global::PhoneStore.Properties.Resources.icons8_logout_32;
            this.pbLogout.Location = new System.Drawing.Point(1297, 3);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(39, 36);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogout.TabIndex = 3;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::PhoneStore.Properties.Resources.icons8_close_32;
            this.pbClose.Location = new System.Drawing.Point(1342, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(36, 36);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 2;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pnUserControls
            // 
            this.pnUserControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUserControls.Location = new System.Drawing.Point(210, 39);
            this.pnUserControls.Name = "pnUserControls";
            this.pnUserControls.Size = new System.Drawing.Size(1390, 861);
            this.pnUserControls.TabIndex = 2;
            this.pnUserControls.Paint += new System.Windows.Forms.PaintEventHandler(this.pnUserControls_Paint);
            // 
            // timerNoti
            // 
            this.timerNoti.Enabled = true;
            this.timerNoti.Tick += new System.EventHandler(this.timerNoti_Tick);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Wheat;
            this.lblUser.Location = new System.Drawing.Point(12, 868);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(70, 23);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnUserControls);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Store Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbYellowBell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel pnUserControls;
        private System.Windows.Forms.Timer timerNoti;
        private System.Windows.Forms.PictureBox pbYellowBell;
        private System.Windows.Forms.Label lblUser;
    }
}

