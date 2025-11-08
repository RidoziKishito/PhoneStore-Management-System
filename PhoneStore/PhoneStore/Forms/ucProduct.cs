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

namespace PhoneStore.Forms
{
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
            LoadData();
            ucP_input.gbInputP.Visible = false;
        }
        Product P = new Product();
        DataTable dt;
        DataSet ds;
        ucProduct_input ucP_input = new ucProduct_input();
        string err = "";
        int uc = 2;
        bool add;
        bool isDelete = false;

        private void btnPSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the IMEI which is needed for all operations
                if (string.IsNullOrWhiteSpace(ucP_input.txtP_imei.Text))
                {
                    MessageBox.Show("Please enter an IMEI/SN.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ucP_input.txtP_imei.Focus();
                    return;
                }

                // Check if this is a delete operation
                isDelete = !add && ucP_input.txtP_imei.ReadOnly && 
                          (!ucP_input.cbP_ProductID.Enabled || !ucP_input.cbP_warranty_id.Enabled);

                // For delete operations, we only need to confirm and delete
                if (isDelete)
                {
                    string imeiToDelete = ucP_input.txtP_imei.Text.Trim();
                    
                    // Final confirmation for deletion
                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete the product with IMEI: {imeiToDelete}?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Use a different variable name to avoid redeclaration
                        bool deleteSuccess = P.DeleteProduct(imeiToDelete, ref err);

                        if (deleteSuccess)
                        {
                            MessageBox.Show("Product deleted successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            // Reset form and reload data
                            LoadData();
                            ResetFormAfterOperation();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete product: " + err, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return;
                }

                // For add and update operations, validate all required fields
                if (ucP_input.cbP_ProductID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Product ID.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ucP_input.cbP_ProductID.Focus();
                    return;
                }

                if (ucP_input.cbP_warranty_id.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Warranty ID.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ucP_input.cbP_warranty_id.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(ucP_input.txtP_status.Text))
                {
                    MessageBox.Show("Please enter a status.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ucP_input.txtP_status.Focus();
                    return;
                }


                // Get values from form
                string imeiValue = ucP_input.txtP_imei.Text.Trim();
                string product_id = ucP_input.cbP_ProductID.SelectedValue?.ToString() ?? "";
                string warranty_id = ucP_input.cbP_warranty_id.SelectedValue?.ToString() ?? "";
                string status = ucP_input.txtP_status.Text.Trim();
                DateTime? warranty_start = null;
                DateTime? warranty_end = null;

                // Validate that we have all required values
                if (string.IsNullOrEmpty(product_id))
                {
                    MessageBox.Show("Invalid Product ID selection.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(warranty_id))
                {
                    MessageBox.Show("Invalid Warranty ID selection.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Use a single boolean for the result
                bool operationSuccess;

                if (add) // Adding new product
                {
                    operationSuccess = P.AddProduct(imeiValue, product_id, warranty_id, status, warranty_start, warranty_end, ref err);
                    if (operationSuccess)
                    {
                        MessageBox.Show("Product added successfully.", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Reset form and reload data
                        LoadData();
                        ResetFormAfterOperation();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product: " + err, "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Updating existing product
                {
                    operationSuccess = P.UpdateProduct(imeiValue, product_id, warranty_id, status, warranty_start, warranty_end, ref err);
                    if (operationSuccess)
                    {
                        MessageBox.Show("Product updated successfully.", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Reset form and reload data
                        LoadData();
                        ResetFormAfterOperation();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product: " + err, "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message + "\nStack trace: " + ex.StackTrace, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to reset the form after an operation completes
        private void ResetFormAfterOperation()
        {
            // Hide and disable the input form
            ucP_input.gbInputP.Visible = false;
            ucP_input.gbInputP.Enabled = false;
            
            // Clear input fields
            ucP_input.txtP_imei.ResetText();
            ucP_input.txtP_imei.ReadOnly = false; // Make sure it's editable for next time
            //ucP_input.txtP_status.ResetText();
            
            // Re-enable all input controls
            if (ucP_input.cbP_ProductID != null)
            {
                ucP_input.cbP_ProductID.Enabled = true;
                ucP_input.cbP_ProductID.SelectedIndex = -1;
            }
            if (ucP_input.cbP_warranty_id != null)
            {
                ucP_input.cbP_warranty_id.Enabled = true;
                ucP_input.cbP_warranty_id.SelectedIndex = -1;
            }
            if (ucP_input.txtP_status != null)
                ucP_input.txtP_status.Enabled = true;
            
            // Reset button states
            btnPUpdate.Enabled = true;
            btnPAdd.Enabled = true;
            btnPDelete.Enabled = true;
            btnPSave.Enabled = false;
            btnPCancel.Enabled = false;
        }

        private void btnPCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // Reset UI state
                ucP_input.gbInputP.Visible = false;
                ucP_input.gbInputP.Enabled = false;

                // Clear input fields
                ucP_input.txtP_imei.ResetText();
                //ucP_input.txtP_status.ResetText();
                // Reset any other input fields you have

                // Reset button states
                btnPUpdate.Enabled = true;
                btnPAdd.Enabled = true;
                btnPDelete.Enabled = true;
                btnPSave.Enabled = false;
                btnPCancel.Enabled = false;

                // Reload data to refresh the view
                LoadData();
                MessageBox.Show("Operation canceled.", "Information",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error during cancel operation: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadData()
        {
            try
            {
                // Check if dgvProducts is initialized
                if (dgvProduct == null)
                {
                    MessageBox.Show("Error: DataGridView not initialized.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if P is initialized
                if (P == null)
                {
                    P = new Product();
                }

                // Get product data
                dt = P.GetProducts();
                dgvProduct.AllowUserToAddRows = false;
                
                // Check if data was retrieved
                if (dt == null)
                {
                    MessageBox.Show("No data retrieved from database.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dt = new DataTable(); // Create empty table to avoid null reference
                }

                // Bind data to the DataGridView
                dgvProduct.DataSource = dt;

                // Reset input fields if ucP_input is initialized
                if (ucP_input != null)
                {
                    ucP_input.txtP_imei.ResetText();
                    //ucP_input.txtP_status.ResetText();
                    
                    // Reset any other input fields you have
                }

                // Enable/Disable buttons
                if (btnPUpdate != null) btnPUpdate.Enabled = true;
                if (btnPAdd != null) btnPAdd.Enabled = true;
                if (btnPDelete != null) btnPDelete.Enabled = true;
                if (btnPSave != null) btnPSave.Enabled = false;
                if (btnPCancel != null) btnPCancel.Enabled = false;

                // Disable input fields
                if (ucP_input != null && ucP_input.gbInputP != null)
                {
                    ucP_input.gbInputP.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product data: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPReload_Click(object sender, EventArgs e)
        {
            LoadData();
            ucP_input.LoadPM_ID_and_Warr_ID();
        }

        private void btnPAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Set flag to indicate we're adding a new product
                add = true;
                pnPInput.Visible = true;
                if (!pnPInput.Controls.Contains(ucP_input))
                {
                    pnPInput.Controls.Add(ucP_input);
                    ucP_input.Dock = DockStyle.Fill;
                }
                // Make sure dropdown lists are populated first (before showing the panel)
                ucP_input.LoadPM_ID_and_Warr_ID();

                // Show and enable the input form
                ucP_input.gbInputP.Visible = true;
                ucP_input.gbInputP.Enabled = true;

                // Clear any existing data in input fields
                ucP_input.txtP_imei.ResetText();
                //ucP_input.txtP_status.ResetText();

                // Clear combo box selections
                if (ucP_input.cbP_ProductID != null)
                {
                    ucP_input.cbP_ProductID.SelectedIndex = -1;
                }

                if (ucP_input.cbP_warranty_id != null)
                {
                    ucP_input.cbP_warranty_id.SelectedIndex = -1;
                }

                // Set focus to the first input field
                ucP_input.txtP_imei.Focus();

                // Configure buttons for add mode
                btnPSave.Enabled = true;
                btnPCancel.Enabled = true;
                btnPAdd.Enabled = false;
                btnPUpdate.Enabled = false;
                btnPDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error preparing to add product: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Set flag to indicate we're updating a product (not adding)
                add = false;
                
                // Check if a row is selected in the DataGridView
                if (dgvProduct.CurrentRow == null)
                {
                    MessageBox.Show("Please select a product to update.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Get data from the selected row
                string imei = dgvProduct.CurrentRow.Cells["imei_sn"].Value.ToString();
                string product_id = dgvProduct.CurrentRow.Cells["product_id"].Value.ToString();
                string warranty_id = dgvProduct.CurrentRow.Cells["warranty_id"].Value.ToString();
                string status = dgvProduct.CurrentRow.Cells["status"].Value.ToString();
                
                // Update column names to match database schema (warranty_start_date and warranty_end_date)
                DateTime warranty_start = Convert.ToDateTime(dgvProduct.CurrentRow.Cells["warranty_start_date"].Value);
                DateTime warranty_end = Convert.ToDateTime(dgvProduct.CurrentRow.Cells["warranty_end_date"].Value);

                // Make the input panel visible
                pnPInput.Visible = true;
                if (!pnPInput.Controls.Contains(ucP_input))
                {
                    pnPInput.Controls.Add(ucP_input);
                    ucP_input.Dock = DockStyle.Fill;
                }

                // Load the dropdown lists
                ucP_input.LoadPM_ID_and_Warr_ID();

                // Show and enable the input form
                ucP_input.gbInputP.Visible = true;
                ucP_input.gbInputP.Enabled = true;

                // Fill form with current values
                ucP_input.txtP_imei.Text = imei;
                ucP_input.txtP_status.Text = status;
                
                // Set the combo box selections
                ucP_input.cbP_ProductID.SelectedValue = product_id;
                ucP_input.cbP_warranty_id.SelectedValue = warranty_id;
                

                // Configure buttons for update mode
                btnPSave.Enabled = true;
                btnPCancel.Enabled = true;
                btnPAdd.Enabled = false;
                btnPUpdate.Enabled = false;
                btnPDelete.Enabled = false;
                
                // Optional: Make IMEI field read-only since it's the primary key
                ucP_input.txtP_imei.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error preparing to update product: " + ex.Message + "\nStack trace: " + ex.StackTrace, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Set flag to indicate we're deleting a product (not adding or updating)
                add = false; // We'll use a new flag for delete in btnPSave_Click
                
                // Check if a row is selected in the DataGridView
                if (dgvProduct.CurrentRow == null)
                {
                    MessageBox.Show("Please select a product to delete.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Get IMEI from the selected row
                string imei = dgvProduct.CurrentRow.Cells["imei_sn"].Value.ToString();
                
                // Make the input panel visible
                pnPInput.Visible = true;
                if (!pnPInput.Controls.Contains(ucP_input))
                {
                    pnPInput.Controls.Add(ucP_input);
                    ucP_input.Dock = DockStyle.Fill;
                }

                // Show and enable the input form, but only the IMEI field
                ucP_input.gbInputP.Visible = true;
                ucP_input.gbInputP.Enabled = true;
                
                // Fill the IMEI field with selected value and make it read-only
                ucP_input.txtP_imei.Text = imei;
                ucP_input.txtP_imei.ReadOnly = true;
                
                // Disable other input fields as we only need the IMEI for deletion
                if (ucP_input.cbP_ProductID != null)
                    ucP_input.cbP_ProductID.Enabled = false;
                if (ucP_input.cbP_warranty_id != null)
                    ucP_input.cbP_warranty_id.Enabled = false;
                if (ucP_input.txtP_status != null)
                    ucP_input.txtP_status.Enabled = false;

                // Configure buttons for delete mode
                btnPSave.Enabled = true;
                btnPCancel.Enabled = true;
                btnPAdd.Enabled = false;
                btnPUpdate.Enabled = false;
                btnPDelete.Enabled = false;
                
                // Show message to confirm deletion
                MessageBox.Show($"Click Save to confirm deletion of product with IMEI: {imei}", "Delete Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error preparing to delete product: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadProductModelID()
        {
            try
            {
                DataTable dt = P.GetProduct_Model_IDs();
                if (dt.Rows.Count > 0)
                {
                    cbP_veiwID.DataSource = dt;
                    cbP_veiwID.DisplayMember = "product_id";
                    cbP_veiwID.ValueMember = "product_id";
                    cbP_veiwID.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu Product.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải Products: {ex.Message}");
            }
        }
        private void btnPM_Show_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an ID is selected
                if (cbP_veiwID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a product ID first.", "Selection Required",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected ID
                string selectedID = cbP_veiwID.SelectedValue.ToString();

                // Get the price for the selected ID
                int quantity = P.GetStockQuantity(selectedID);

                // Create a DataTable to display the result
                DataTable dtResult = new DataTable();
                dtResult.Columns.Add("ProductModelID", typeof(string));
                dtResult.Columns.Add("Quantity", typeof(int));
                dtResult.Rows.Add(selectedID, quantity);

                // Display the result in the DataGridView
                dgvProduct.DataSource = dtResult;

                // Format the price column
                dgvProduct.Columns["Quantity"].DefaultCellStyle.Format = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying product information: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            LoadProductModelID();
        }
    }
}
