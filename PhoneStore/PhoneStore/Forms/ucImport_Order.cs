using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneStore.AdditionalFunctions;
using PhoneStore.Business;

namespace PhoneStore.Forms
{
    public partial class ucImport_Order : UserControl
    {
        public ucImport_Order()
        {
            InitializeComponent();
        }

        string err = "";
        ImportOrder bio = new ImportOrder();
        public event EventHandler AddedTVP;
        private void ResetUC()
        {
            dgvDetail.DataSource = null;
            dgvDetail.Refresh();
            gbDetail.Enabled = false;

            gbImportOrder.Enabled = false;
        }
        private void ucImport_Order_Load(object sender, EventArgs e)
        {
            ResetUC();
        }

        private void gbDetail_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    cbProduct.SelectedIndex != -1
                    && !String.IsNullOrEmpty(txtImportPrice.Text)
                    && nudQuantity.Value > 0
                    )
                {
                    string comboText = cbProduct.Text;
                    string id = comboText.Split('-')[0].Trim();
                    string name = comboText.Split('-')[1].Trim();
                    decimal quantity = nudQuantity.Value;

                    dgvDetail.Rows.Add(id, name, quantity.ToString(), txtImportPrice.Text);
                    dgvDetail.Refresh();
                    GlobalState.total_product += quantity * Convert.ToDecimal(txtImportPrice.Text);
                    txtTotal.Text = GlobalState.total_product.ToString();
                }
                else throw new Exception("Invalid input!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetail.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Confirm row deletion?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvDetail.SelectedRows)
                        {
                            if (!row.IsNewRow)
                            {
                                GlobalState.total_product -= Convert.ToDecimal(row.Cells[3].Value) * Convert.ToDecimal(row.Cells[2].Value);
                                dgvDetail.Rows.Remove(row);
                                txtTotal.Text = GlobalState.total_product.ToString();
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception("Please select a row to delete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Confirm saving this table?", 
                    "Saving confirmation", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (dgvDetail.Rows.Count - 1 > 0)
                    {
                        // Create DataTable to store the data from the DataGridView
                        DataTable detailRow = new DataTable();

                        // Add columns to the DataTable
                        detailRow.Columns.Add("product_id", typeof(string));         // Column for Product ID
                        detailRow.Columns.Add("import_quantity", typeof(int));    // Column for Quantity
                        detailRow.Columns.Add("import_price", typeof(decimal));   // Column for Price

                        // Loop through each row of the DataGridView
                        foreach (DataGridViewRow row in dgvDetail.Rows)
                        {
                            // Skip the "new row" in DataGridView if exists
                            if (!row.IsNewRow)
                            {
                                // Add data from each row into the DataTable
                                detailRow.Rows.Add(
                                    Convert.ToString(row.Cells["product_id"].Value),        // Product ID
                                    Convert.ToInt32(row.Cells["import_quantity"].Value),   // Quantity
                                    Convert.ToDecimal(row.Cells["import_price"].Value)     // Price
                                );

                                string supplier_id = cbSuppliers.Text.Split('-')[0].Trim();
                                bio.AddImportOrder(supplier_id, GlobalState.total_product, dtpImportDate.Value, detailRow, ref err);
                                AddedTVP?.Invoke(this, EventArgs.Empty);
                            }
                        }
                    }
                    ResetInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void ResetInput()
        {
            cbSuppliers.Text = string.Empty;
            dtpImportDate.Value = DateTime.Now;
            txtSupplierName.Text = string.Empty;
            txtTotal.Text = string.Empty;
            cbProduct.Text = string.Empty;
            txtImportPrice.Text = string.Empty;
            nudQuantity.Value = 0;

            gbDetail.Enabled = false;
            gbImportOrder.Enabled = false;
        }

    }
}
