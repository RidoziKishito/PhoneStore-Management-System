namespace PhoneStore.Forms
{
    partial class ucDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart_Top5Suppliers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Top10Products = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_TopEmployees = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Top10Customers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Top5Suppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Top10Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_TopEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Top10Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Top5Suppliers
            // 
            this.chart_Top5Suppliers.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            chartArea1.Name = "ChartArea1";
            this.chart_Top5Suppliers.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Top5Suppliers.Legends.Add(legend1);
            this.chart_Top5Suppliers.Location = new System.Drawing.Point(10, 8);
            this.chart_Top5Suppliers.Margin = new System.Windows.Forms.Padding(4);
            this.chart_Top5Suppliers.Name = "chart_Top5Suppliers";
            this.chart_Top5Suppliers.Size = new System.Drawing.Size(676, 419);
            this.chart_Top5Suppliers.TabIndex = 3;
            this.chart_Top5Suppliers.Text = "chart1";
            // 
            // chart_Top10Products
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Top10Products.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Top10Products.Legends.Add(legend2);
            this.chart_Top10Products.Location = new System.Drawing.Point(703, 8);
            this.chart_Top10Products.Margin = new System.Windows.Forms.Padding(4);
            this.chart_Top10Products.Name = "chart_Top10Products";
            this.chart_Top10Products.Size = new System.Drawing.Size(676, 419);
            this.chart_Top10Products.TabIndex = 4;
            this.chart_Top10Products.Text = "chart1";
            // 
            // chart_TopEmployees
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_TopEmployees.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_TopEmployees.Legends.Add(legend3);
            this.chart_TopEmployees.Location = new System.Drawing.Point(10, 435);
            this.chart_TopEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.chart_TopEmployees.Name = "chart_TopEmployees";
            this.chart_TopEmployees.Size = new System.Drawing.Size(676, 419);
            this.chart_TopEmployees.TabIndex = 5;
            this.chart_TopEmployees.Text = "chart_TopEmployees";
            // 
            // chart_Top10Customers
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_Top10Customers.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_Top10Customers.Legends.Add(legend4);
            this.chart_Top10Customers.Location = new System.Drawing.Point(703, 435);
            this.chart_Top10Customers.Margin = new System.Windows.Forms.Padding(4);
            this.chart_Top10Customers.Name = "chart_Top10Customers";
            this.chart_Top10Customers.Size = new System.Drawing.Size(676, 419);
            this.chart_Top10Customers.TabIndex = 6;
            this.chart_Top10Customers.Text = "chart1";
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart_Top10Customers);
            this.Controls.Add(this.chart_TopEmployees);
            this.Controls.Add(this.chart_Top10Products);
            this.Controls.Add(this.chart_Top5Suppliers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1389, 862);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Top5Suppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Top10Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_TopEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Top10Customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Top5Suppliers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Top10Products;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_TopEmployees;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Top10Customers;
    }
}
