using PhoneStore.AdditionalFunctions;
using PhoneStore.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStore.Forms
{
    public partial class ucOrder : UserControl
    {
        public ucOrder()
        {
            InitializeComponent();
            ucOrderDetail.SetUcOrderInstance(this);
            ResetInput();
        }
        SaleOrder order = new SaleOrder();
        public void LoadOrders()
        {
            dgvOrders.DataSource = order.GetAllOrders();
        }
        private void LoadCustomerIDs()
        {
            DataTable dt = order.GetCustomers();
            cbCustomerID.DataSource = dt;
            cbCustomerID.DisplayMember = "customer_name";
            cbCustomerID.ValueMember = "customer_id";
            cbCustomerID.SelectedIndex = -1; // để trống ban đầu
            cbLoadOrdersByCustomer.DataSource = dt;
            cbLoadOrdersByCustomer.DisplayMember = "customer_name";
            cbLoadOrdersByCustomer.ValueMember = "customer_id";
            cbLoadOrdersByCustomer.SelectedIndex = -1; // để trống ban đầu
        }

        private void LoadEmployeeIDs()
        {
            DataTable dt = order.GetEmployees();
            cbEmployeeID.DataSource = dt;
            cbEmployeeID.DisplayMember = "employee_name";
            cbEmployeeID.ValueMember = "employee_id";
            cbEmployeeID.SelectedIndex = -1;
        }

        private void LoadPromotionIDs()
        {
            DataTable dt = order.GetPromotions();
            cbPromotionID.DataSource = dt;
            cbPromotionID.DisplayMember = "promotion_id";
            cbPromotionID.ValueMember = "promotion_id";
            cbPromotionID.SelectedIndex = -1;
        }
        private void ucOrder_Load(object sender, EventArgs e)
        {
            LoadOrders();
            LoadCustomerIDs();
            LoadEmployeeIDs();
            LoadPromotionIDs();
            cbPayment.Items.AddRange(new string[] { "Cash", "Credit Card", "Transfer" });
            cbStatus.Items.AddRange(new string[] { "Pending", "Completed", "Cancelled" });
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;
            dgvOrders.ReadOnly = true;
            cbLoadOrdersByStatus.Items.AddRange(new string[] { "Pending", "Completed", "Cancelled" });
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                gbOrderInfo.Enabled = false;
                GlobalState.total_sale_order = 0;
                txtTotalValue.Text = GlobalState.total_sale_order.ToString();
                ucOrderDetail.gbOrderDetailInfo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrders.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please pick a sale order.");
                    return;
                }

                string id = dgvOrders.SelectedRows[0].Cells[0].Value.ToString();

                DialogResult confirmResult = MessageBox.Show(
                    $"Confirm delete ID: {id}?",
                    "Delete confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.No)
                    return;

                string error = "";
                bool result = order.DeleteOrder(id, ref error);

                if (result)
                {
                    MessageBox.Show("Delete successfully!");
                    LoadOrders();
                }
                else
                {
                    MessageBox.Show("Error: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void btnByDate_Click(object sender, EventArgs e)
        {
            DateTime saleDate = dtpSaleDate.Value;
            dgvOrders.DataSource = order.GetSaleOrdersByDate(saleDate);
        }

        private void btnByStatus_Click(object sender, EventArgs e)
        {
            string status = cbLoadOrdersByStatus.SelectedItem.ToString();
            dgvOrders.DataSource = order.GetSaleOrdersByStatus(status);
        }

        private void btnByCustomer_Click(object sender, EventArgs e)
        {
            if (cbCustomerID.SelectedValue == null) return;

            string customerId = cbLoadOrdersByCustomer.SelectedValue.ToString();
            dgvOrders.DataSource = order.GetSaleOrdersByCustomer(customerId);
        }

        private void btnTotalRevenue_Click(object sender, EventArgs e)
        {
            decimal total = order.GetTotalRevenue(dtpStart.Value, dtpEnd.Value);
            MessageBox.Show($"Total revenue: {total:N0} $");
        }

        private void btnTotalDiscount_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please pick an order.");
                return;
            }

            string orderId = dgvOrders.SelectedRows[0].Cells["order_id"].Value.ToString();
            decimal discount = order.GetTotalDiscount(orderId);
            MessageBox.Show($"Total Discount: {discount:N0} VNĐ");
        }
        private void ucOrderDetail_Load(object sender, EventArgs e)
        {

        }

        public void ResetInput()
        {
            cbCustomerID.SelectedIndex = -1;
            cbEmployeeID.SelectedIndex = -1;
            cbPromotionID.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            cbPromotionID.SelectedIndex = -1;
            cbPayment.SelectedIndex = -1;
            dtpSaleDate.Value = DateTime.Now;
            txtTotalValue.Text = string.Empty;
            GlobalState.total_sale_order = 0;
            ucOrderDetail.nudDiscount.Value = 0;
            ucOrderDetail.cbImeiSN.SelectedIndex = -1;
            ucOrderDetail.txtSellingPrice.Text = string.Empty;
            ucOrderDetail.dgvOrderDetails.Rows.Clear();
            ucOrderDetail.gbOrderDetailInfo.Enabled = false;
            gbOrderInfo.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                LoadOrders();
                dgvOrders.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
