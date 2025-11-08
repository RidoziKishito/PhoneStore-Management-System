using PhoneStore.AdditionalFunctions;
using PhoneStore.Business;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStore.Forms
{
    public partial class ucOrderDetail : UserControl
    {
        SaleOrderDetail detail = new SaleOrderDetail();
        ProductModel pm = new ProductModel();
        decimal price = 0;
        SaleOrder saleOrder = new SaleOrder();
        ucOrder ucOrder;
        public ucOrderDetail()
        {
            InitializeComponent();
        }

        public void SetUcOrderInstance(ucOrder instance)
        {
            ucOrder = instance;
        }

        private void ucOrderDetail_Load(object sender, EventArgs e) 
        {
            // LoadSaleOrderDetails(); Change to use the DGV for TVP input
            // LoadOrderIDs();
            LoadIMEIs();
        }
        private void LoadSaleOrderDetails() // Load combo box
        {
            dgvOrderDetails.DataSource = detail.GetAllSaleOrderDetails();
        }
        private void LoadOrderIDs() // Load combo box
        {
            try
            {
                DataTable dt = detail.GetOrderIDs();
                if (dt.Rows.Count > 0)
                {
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu Order IDs.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải Order IDs: {ex.Message}");
            }
        }

        private void LoadIMEIs()
        {
            try
            {
                DataTable dt = detail.GetIMEIs();
                if (dt.Rows.Count > 0)
                {
                    dt.Columns.Add("DisplayField", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        row["DisplayField"] = $"{row[0]} - {row[2]}";
                    }

                    cbImeiSN.DataSource = dt;
                    cbImeiSN.DisplayMember = "DisplayField";
                    cbImeiSN.ValueMember = "imei_sn"; // Hoặc cột bạn muốn dùng làm giá trị
                    cbImeiSN.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnAddOrderDetail_Click(object sender, EventArgs e)
        {
            try
            {
                string error = "";

                string cusID = GetComboBoxValueByColumnIndex(ucOrder.cbCustomerID, 0);
                string emId = GetComboBoxValueByColumnIndex(ucOrder.cbEmployeeID, 0);
                string proID = ucOrder.cbPromotionID.Text;
                string paymentMethod = ucOrder.cbPayment.Text;
                string status = ucOrder.cbStatus.Text;

                DateTime saleDate = ucOrder.dtpSaleDate.Value;
                DataTable tvp = ConvertDGVToDataTable(dgvOrderDetails);

                if (tvp != null)
                {
                    bool res = saleOrder.AddOrder(cusID, emId, proID, paymentMethod, saleDate, status, GlobalState.total_sale_order, tvp, ref error);
                    if (res)
                    {
                        ucOrder.LoadOrders();
                        dgvOrderDetails.Rows.Clear();
                        ResetInput();
                    }
                }
                else throw new Exception("Cannot load data from DGV");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetComboBoxValueByColumnIndex(ComboBox comboBox, int columnIndex)
        {
            if (comboBox.SelectedItem is DataRowView row && columnIndex < row.Row.ItemArray.Length)
            {
                return row[columnIndex]?.ToString();
            }
            return "";
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrderDetails.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvOrderDetails.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            GlobalState.total_sale_order -= Convert.ToDecimal(row.Cells[2].Value);
                            dgvOrderDetails.Rows.Remove(row);
                        }
                    }
                }
                ucOrder.txtTotalValue.Text = GlobalState.total_sale_order.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gbOrderDetailInfo_Enter(object sender, EventArgs e)
        {

        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbImeiSN.SelectedIndex == -1) throw new Exception("Please choose a product first!");
                else if (nudDiscount.Value > 0)
                    RecalculatePrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbImeiSN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbImeiSN.SelectedIndex != -1)
                RecalculatePrice();
        }
        private void RecalculatePrice()
        {
            try
            {
                DataRowView selectedRow = (DataRowView)cbImeiSN.SelectedItem;
                price = pm.GetListedPrice(selectedRow[1].ToString());
                price *= (1 - nudDiscount.Value / 100);
                txtSellingPrice.Text = price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cbImeiSN.SelectedItem;
            string imei_sn = selectedRow[0].ToString();
            dgvOrderDetails.Rows.Add(new string[] 
                {
                imei_sn,
                nudDiscount.Value.ToString(),
                txtSellingPrice.Text
                }
            );
            dgvOrderDetails.Refresh();
            GlobalState.total_sale_order += Convert.ToDecimal(txtSellingPrice.Text);
            ucOrder.txtTotalValue.Text = GlobalState.total_sale_order.ToString();
        }

        private DataTable ConvertDGVToDataTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                dt.Columns.Add(col.Name, col.ValueType ?? typeof(string));
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dataRow = dt.NewRow();
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        dataRow[col.Name] = row.Cells[col.Index].Value ?? DBNull.Value;
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }

        private void ResetInput()
        {
            ucOrder.ResetInput();
        }
    }

}
