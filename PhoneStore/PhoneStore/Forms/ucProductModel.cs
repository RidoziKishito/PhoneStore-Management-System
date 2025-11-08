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
using System.IO;


namespace PhoneStore.Forms
{
    
    public partial class ucProductModel : UserControl
    {
        public ucProductModel()
        {
            InitializeComponent();
            LoadData();
            ucPM_input.gbInputPM.Enabled = false;
            
        }
        #region Initialization
        ProductModel PM = new ProductModel();
        DataTable dt;
        DataSet ds;
        ucProduct_Model_input ucPM_input = new ucProduct_Model_input();
        string err = "";
        int uc = 2;
        bool add;
        PictureBox product_picture = new PictureBox();
        #endregion

        //#region Buttons

        private void btnPMSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected operation mode (determined when clicking Add/Update/Delete buttons)
                // For delete operation
                if (ucPM_input.cbPM_ProductID.Enabled && !ucPM_input.txtPM_Product_name.Enabled)
                {
                    // We're in delete mode
                    if (ucPM_input.cbPM_ProductID.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a product ID to delete.", "Selection Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string selectedProductId = ucPM_input.cbPM_ProductID.SelectedValue.ToString();

                    // Confirm deletion with the user
                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete the product model with ID: {selectedProductId}?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Attempt to delete the product model
                        bool success = PM.DeleteProductModel(selectedProductId, ref err);

                        if (!success)
                        {
                            MessageBox.Show("Error deleting product model: " + err, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        MessageBox.Show("Product model deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // User canceled the deletion
                        return;
                    }
                }
                // For add operation
                else if (add)
                {
                    // Validate inputs before adding
                    if (string.IsNullOrWhiteSpace(ucPM_input.txtPM_Product_name.Text) ||
                        string.IsNullOrWhiteSpace(ucPM_input.txtPM_brand.Text) ||
                        string.IsNullOrWhiteSpace(ucPM_input.txtPM_ListedPrice.Text))
                    {
                        MessageBox.Show("Please fill in all required fields.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Gather data from input fields
                    string productName = ucPM_input.txtPM_Product_name.Text.Trim();
                    string brand = ucPM_input.txtPM_brand.Text.Trim();
                    int quantity = (int)ucPM_input.numericUpDown1.Value;
                    decimal listedPrice;

                    if (!decimal.TryParse(ucPM_input.txtPM_ListedPrice.Text, out listedPrice))
                    {
                        MessageBox.Show("Please enter a valid price.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Call your ProductModel's add method
                    bool success = PM.AddProductModel(productName, brand, quantity, listedPrice, ref err);

                    if (!success)
                    {
                        MessageBox.Show("Error adding product model: " + err, "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Product model added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // For update operation
                else
                {
                    // We're in update mode
                    if (ucPM_input.cbPM_ProductID.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a product ID to update.", "Selection Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate inputs before updating
                    if (string.IsNullOrWhiteSpace(ucPM_input.txtPM_Product_name.Text) ||
                        string.IsNullOrWhiteSpace(ucPM_input.txtPM_brand.Text) ||
                        string.IsNullOrWhiteSpace(ucPM_input.txtPM_ListedPrice.Text))
                    {
                        MessageBox.Show("Please fill in all required fields.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Gather data from input fields
                    string productId = ucPM_input.cbPM_ProductID.SelectedValue.ToString();
                    string productName = ucPM_input.txtPM_Product_name.Text.Trim();
                    string brand = ucPM_input.txtPM_brand.Text.Trim();
                    int quantity = (int)ucPM_input.numericUpDown1.Value;
                    decimal listedPrice;

                    if (!decimal.TryParse(ucPM_input.txtPM_ListedPrice.Text, out listedPrice))
                    {
                        MessageBox.Show("Please enter a valid price.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Call your ProductModel's update method
                    bool success = PM.UpdateProductModel(productId, productName, brand, quantity, listedPrice, ref err);

                    if (!success)
                    {
                        MessageBox.Show("Error updating product model: " + err, "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Product model updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Common actions after any operation succeeds
                // Reload data and reset UI
                LoadData();
                LoadProductModelID();
                pnPMInput.Visible = false;
                ucPM_input.Visible = false;

                // Reset buttons state
                btnPMUpdate.Enabled = true;
                btnPMAdd.Enabled = true;
                btnPMDelete.Enabled = true;
                btnPMSave.Enabled = false;
                btnPMCancel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPMAdd_Click(object sender, EventArgs e)
        {
            pnPMInput.Controls.Remove(product_picture);
            // Set mode flag
            add = true;

            // Show panel and input control
            pnPMInput.Visible = true;

            // Initialize the input control if not already added to panel
            if (!pnPMInput.Controls.Contains(ucPM_input))
            {
                pnPMInput.Controls.Add(ucPM_input);
                ucPM_input.Dock = DockStyle.Fill;
            }

            // Show the input control
            ucPM_input.Visible = true;

            // Clear input fields
            ucPM_input.txtPM_Product_name.Clear();
            ucPM_input.txtPM_brand.Clear();
            ucPM_input.numericUpDown1.Value = 0;
            ucPM_input.txtPM_ListedPrice.Clear();
            ucPM_input.cbPM_ProductID.Enabled = false;

            // Enable the GroupBox
            ucPM_input.gbInputPM.Enabled = true;

            // Update button states
            btnPMAdd.Enabled = false;
            btnPMUpdate.Enabled = false;
            btnPMDelete.Enabled = false;
            btnPMSave.Enabled = true;
            btnPMCancel.Enabled = true;

        }

        private void btnPMReload_Click(object sender, EventArgs e)
        {
            LoadData();
            ucPM_input.LoadProductModelID();
            AddPicture("phones.jpg");
        }
        private void LoadData()
        {
            try
            {
                // Check if dgvProductModel is initialized
                if (dgvProductModel == null)
                {
                    MessageBox.Show("Error: DataGridView not initialized.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if PM is initialized
                if (PM == null)
                {
                    PM = new ProductModel();
                }

                // Get full product data
                dt = PM.GetProductsModel();
                dgvProductModel.AllowUserToAddRows = false;
                // Check if data was retrieved
                if (dt == null)
                {
                    MessageBox.Show("No data retrieved from database.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dt = new DataTable(); // Create empty table to avoid null reference
                }

                // Bind data to the DataGridView
                dgvProductModel.DataSource = dt;

                // Reset input fields if ucPM_input is initialized
                if (ucPM_input != null)
                {
                    ucPM_input.txtPM_Product_name.ResetText();
                    ucPM_input.txtPM_brand.ResetText();
                    ucPM_input.numericUpDown1.Value = 0;
                    ucPM_input.txtPM_ListedPrice.ResetText();
                }

                // Enable/Disable buttons
                if (btnPMUpdate != null) btnPMUpdate.Enabled = true;
                if (btnPMAdd != null) btnPMAdd.Enabled = true;
                if (btnPMDelete != null) btnPMDelete.Enabled = true;
                if (btnPMSave != null) btnPMSave.Enabled = false;
                if (btnPMCancel != null) btnPMCancel.Enabled = false;

                // Disable input fields
                if (ucPM_input != null && ucPM_input.gbInputPM != null)
                {
                    ucPM_input.gbInputPM.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product data: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Ensure a valid row is selected
                {
                    DataGridViewRow row = dgvProductModel.Rows[e.RowIndex];

                    // Get the string value of column index 5
                    string ImageName = row.Cells[5].Value?.ToString() ?? "";

                    AddPicture(ImageName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnPMDelete_Click(object sender, EventArgs e)
        {
            try
            {
                pnPMInput.Controls.Remove(product_picture);
                add = false;

                 pnPMInput.Visible = true;

                // Initialize the input control if not already added to panel
                if (!pnPMInput.Controls.Contains(ucPM_input))
                {
                    pnPMInput.Controls.Add(ucPM_input);
                    ucPM_input.Dock = DockStyle.Fill;
                }

                // Show the input control
                ucPM_input.Visible = true;

                // Make sure the product ID combobox is populated
                ucPM_input.LoadProductModelID();

                // Only enable the ComboBox for selecting the product ID
                ucPM_input.gbInputPM.Enabled = true;
                ucPM_input.cbPM_ProductID.Enabled = true;
                ucPM_input.txtPM_Product_name.Enabled = false;
                ucPM_input.txtPM_brand.Enabled = false;
                ucPM_input.numericUpDown1.Enabled = false;
                ucPM_input.txtPM_ListedPrice.Enabled = false;

                // Update button states
                btnPMAdd.Enabled = false;
                btnPMUpdate.Enabled = false;
                btnPMDelete.Enabled = false;
                btnPMSave.Enabled = true;  // Enable save button for deletion confirmation
                btnPMCancel.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPMCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide the input panel
                pnPMInput.Visible = false;
                ucPM_input.Visible = false;

                // Reset input fields
                if (ucPM_input != null)
                {
                    ucPM_input.cbPM_ProductID.SelectedIndex = -1;
                    ucPM_input.txtPM_Product_name.Clear();
                    ucPM_input.txtPM_brand.Clear();
                    ucPM_input.numericUpDown1.Value = 0;
                    ucPM_input.txtPM_ListedPrice.Clear();
                }

                // Reset button states
                btnPMAdd.Enabled = true;
                btnPMUpdate.Enabled = true;
                btnPMDelete.Enabled = true;
                btnPMSave.Enabled = false;
                btnPMCancel.Enabled = false;

                // Reset the add flag
                add = false;

                // Disable input fields to prevent further editing until an operation is selected
                if (ucPM_input != null && ucPM_input.gbInputPM != null)
                {
                    ucPM_input.gbInputPM.Enabled = false;
                }

                // Show a message to inform the user
                MessageBox.Show("Operation canceled.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during cancel operation: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPMUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                pnPMInput.Controls.Remove(product_picture);
                // Set mode flag to indicate we're in update mode, not add mode
                add = false;

                // Show panel and input control
                pnPMInput.Visible = true;

                // Initialize the input control if not already added to panel
                if (!pnPMInput.Controls.Contains(ucPM_input))
                {
                    pnPMInput.Controls.Add(ucPM_input);
                    ucPM_input.Dock = DockStyle.Fill;
                }

                // Show the input control
                ucPM_input.Visible = true;

                // Make sure the product ID combobox is populated
                ucPM_input.LoadProductModelID();

                // Enable the required fields for update
                ucPM_input.gbInputPM.Enabled = true;
                ucPM_input.cbPM_ProductID.Enabled = true;  // Allow selection of product ID
                ucPM_input.txtPM_Product_name.Enabled = true;
                ucPM_input.txtPM_brand.Enabled = true;
                ucPM_input.numericUpDown1.Enabled = true;
                ucPM_input.txtPM_ListedPrice.Enabled = true;

                // Clear input fields initially
                ucPM_input.txtPM_Product_name.Clear();
                ucPM_input.txtPM_brand.Clear();
                ucPM_input.numericUpDown1.Value = 0;
                ucPM_input.txtPM_ListedPrice.Clear();

                // Update button states
                btnPMAdd.Enabled = false;
                btnPMUpdate.Enabled = false;
                btnPMDelete.Enabled = false;
                btnPMSave.Enabled = true;
                btnPMCancel.Enabled = true;

                // Display instructions
                MessageBox.Show("Please select a product ID from the dropdown, modify the fields as needed, then click Save to update.",
                    "Update Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in update operation: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void LoadProductModelID()
        {
            try
            {
                DataTable dt = PM.GetProduct_Model_IDs();
                if (dt.Rows.Count > 0)
                {
                    // Create a new column that combines ID and Name
                    dt.Columns.Add("DisplayValue", typeof(string), "product_id + ' - ' + product_name");

                    cbPM_veiwID.DataSource = dt;
                    cbPM_veiwID.DisplayMember = "DisplayValue"; // Show "ID - Name"
                    cbPM_veiwID.ValueMember = "product_id";
                    cbPM_veiwID.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No product data!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ucProductModel_Load(object sender, EventArgs e)
        {
            LoadProductModelID();
            AddPicture("phones.jpg");
        }
        private void btnPM_Show_Click(object sender, EventArgs e)
        {
            try
            { 
                // Check if an ID is selected
                if (cbPM_veiwID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a product ID first.", "Selection Required",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected ID
                string selectedID = cbPM_veiwID.SelectedValue.ToString().Split('-')?[0].Trim();

                // Get the price for the selected ID
                decimal price = PM.GetListedPrice(selectedID);

                // Create a DataTable to display the result
                DataTable dtResult = new DataTable();
                dtResult.Columns.Add("ProductModelID", typeof(string));
                dtResult.Columns.Add("ListedPrice", typeof(decimal));
                dtResult.Rows.Add(selectedID, price);

                // Display the result in the DataGridView
                dgvProductModel.DataSource = dtResult;

                // Format the price column
                dgvProductModel.Columns["ListedPrice"].DefaultCellStyle.Format = "C2";
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying product information: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblIcon_Click(object sender, EventArgs e)
        {

        }

        private void AddPicture(string imageName)
        {
            if (product_picture.Image != null)
            {
                product_picture.Image.Dispose();
                product_picture.Image = null;
            }
            product_picture.Size = new Size(480, 495); // Set size
            product_picture.Location = new Point(10, 10); // Set position
            string imagePath = Path.Combine(Application.StartupPath, @"..\..\ProductPictures\", imageName);
            string fullImagePath = Path.GetFullPath(imagePath);
            product_picture.Image = Image.FromFile(fullImagePath);
            product_picture.SizeMode = PictureBoxSizeMode.Zoom;

            pnPMInput.Controls.Add(product_picture);
            pnPMInput.Visible = true;
            pnPMInput.Refresh();
        }

        private void llblAddPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddPictureForm addPictureForm = new AddPictureForm();
            addPictureForm.ShowDialog();
        }














        //#endregion


    }
}
