using PhoneStore.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace PhoneStore.Forms
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            // Top 5 Customers in this year
            Series seriesTop5Sup = new Series("Number of orders");
            seriesTop5Sup.ChartType = SeriesChartType.Column;
            DataTable Top5Sup = DashBoard.GetTop5SuppliersForCurrentYear();
            foreach (DataRow row in Top5Sup.Rows)
            {
                seriesTop5Sup.Points.AddXY(row["supplier_name"], row["order_count"]);
            }
            chart_Top5Suppliers.Series.Add(seriesTop5Sup);
            chart_Top5Suppliers.Titles.Add("Top 5 Suppliers In This Year");
            chart_Top5Suppliers.ChartAreas[0].AxisX.Title = "Supplier Name";
            chart_Top5Suppliers.ChartAreas[0].AxisY.Title = "Orders";


            // Top 10 Products in this year
            Series seriesTop10Products = new Series("Number of sales");
            seriesTop10Products.ChartType = SeriesChartType.Column;
            DataTable Top10Products = DashBoard.GetTop10BestSellingProductsForCurrentYear();
            foreach (DataRow row in Top10Products.Rows)
            {
                seriesTop10Products.Points.AddXY(row["product_name"], row["sales_count"]);
            }
            chart_Top10Products.Series.Add(seriesTop10Products);
            chart_Top10Products.Titles.Add("Top 10 Best Selling Products In This Year");
            chart_Top10Products.ChartAreas[0].AxisX.Title = "Product Name";
            chart_Top10Products.ChartAreas[0].AxisY.Title = "Sales";
            // Top Employees in this year
            Series seriesTopEmployees = new Series("Revenue");
            seriesTopEmployees.ChartType = SeriesChartType.Column;
            DataTable TopEmployees = DashBoard.GetTopEmployeesByRevenueForCurrentYear();
            foreach (DataRow row in TopEmployees.Rows)
            {
                seriesTopEmployees.Points.AddXY(row["employee_name"], row["total_revenue"]);
            }
            chart_TopEmployees.Series.Add(seriesTopEmployees);
            chart_TopEmployees.Titles.Add("Top Employees In This Year");
            chart_TopEmployees.ChartAreas[0].AxisX.Title = "Employee Name";
            chart_TopEmployees.ChartAreas[0].AxisY.Title = "Revenue";
            // Top Customers
            Series seriesTopCustomers = new Series("Spending");
            seriesTopCustomers.ChartType = SeriesChartType.Column;
            DataTable TopCustomers = DashBoard.GetTop10Customers();
            foreach (DataRow row in TopCustomers.Rows)
            {
                seriesTopCustomers.Points.AddXY(row["CustomerName"], row["TotalSpending"]);
            }
            chart_Top10Customers.Series.Add(seriesTopCustomers);
            chart_Top10Customers.Titles.Add("Top 10 Customers");
            chart_Top10Customers.ChartAreas[0].AxisX.Title = "Customer Name";
            chart_Top10Customers.ChartAreas[0].AxisY.Title = "Total Spending";
        }
        private void ucDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
