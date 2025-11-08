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
    public partial class ucTechnical_Spec : UserControl
    {
        public ucTechnical_Spec()
        {
            InitializeComponent();
            LoadData();
            ucTS_input.gbInputTS.Enabled = false;
        }
        #region Initialization
        Technical_Specs TS = new Technical_Specs();
        DataTable dt;
        DataSet ds;
        ucTech_Specs_input ucTS_input = new ucTech_Specs_input();
        string err = " ";
        int uc = 2;
        bool add;
        #endregion

        private void LoadData()
        {
            try
            {
                // Check if dgvTechSpecs is initialized
                if (dgvTechSpecs == null)
                {
                    MessageBox.Show("Error: DataGridView not initialized.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if TS is initialized
                if (TS == null)
                {
                    TS = new Technical_Specs();
                }

                // Get technical specifications data
                dt = TS.getTechnicalSpecs();
                dgvTechSpecs.AllowUserToAddRows = false;

                // Check if data was retrieved
                if (dt == null)
                {
                    MessageBox.Show("No data retrieved from database.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dt = new DataTable(); // Create empty table to avoid null reference
                }

                // Bind data to the DataGridView
                dgvTechSpecs.DataSource = dt;

                // Reset input fields if ucTS_input is initialized
                if (ucTS_input != null)
                {
                    // Reset your specific input fields here, for example:
                    ucTS_input.txtTS_Tech_name.ResetText();
                    ucTS_input.txtTS_Details.ResetText();


                }

                // Enable/Disable buttons
                if (btnTSUpdate != null) btnTSUpdate.Enabled = true;
                if (btnTSAdd != null) btnTSAdd.Enabled = true;
                if (btnTSDelete != null) btnTSDelete.Enabled = true;
                if (btnTSSave != null) btnTSSave.Enabled = false;
                if (btnTSCancel != null) btnTSCancel.Enabled = false;

                // Disable input fields
                if (ucTS_input != null && ucTS_input.gbInputTS != null)
                {
                    ucTS_input.gbInputTS.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading technical specifications data: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPMReload_Click(object sender, EventArgs e)
        {
            LoadData();
            ucTS_input.LoadProductModelID();
        }

        private void btnTSAdd_Click(object sender, EventArgs e)
        {
            // Set mode flag
            add = true;

            // Show panel and input control
            pnTSInput.Visible = true;

            // Initialize the input control if not already added to panel
            if (!pnTSInput.Controls.Contains(ucTS_input))
            {
                pnTSInput.Controls.Add(ucTS_input);
                ucTS_input.Dock = DockStyle.Fill;
            }

            // Show the input control
            ucTS_input.Visible = true;

            // Clear input fields
            ucTS_input.txtTS_Tech_name.Clear();
            ucTS_input.txtTS_Details.Clear();

            // Enable the GroupBox
            ucTS_input.gbInputTS.Enabled = true;

            // Update button states
            btnTSAdd.Enabled = false;
            btnTSUpdate.Enabled = false;
            btnTSDelete.Enabled = false;
            btnTSSave.Enabled = true;
            btnTSCancel.Enabled = true;
        }

        private void btnTSUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there's data in the DataGridView
                if (dgvTechSpecs.Rows.Count == 0)
                {
                    MessageBox.Show("No technical specifications available to update.",
                        "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Set mode flag to indicate we're in update mode, not add mode
                add = false;

                // Show panel and input control
                pnTSInput.Visible = true;

                // Initialize the input control if not already added to panel
                if (!pnTSInput.Controls.Contains(ucTS_input))
                {
                    pnTSInput.Controls.Add(ucTS_input);
                    ucTS_input.Dock = DockStyle.Fill;
                }

                // Show the input control
                ucTS_input.Visible = true;

                // Make sure the product ID combobox is populated
                ucTS_input.LoadProductModelID();

                // Enable the required fields for update
                ucTS_input.gbInputTS.Enabled = true;
                ucTS_input.cbTS_ProductID.Enabled = true;  // Allow selection of product ID
                ucTS_input.txtTS_Tech_name.Enabled = true;
                ucTS_input.txtTS_Details.Enabled = true;


                // Clear input fields initially
                ucTS_input.txtTS_Tech_name.Clear();
                ucTS_input.txtTS_Details.Clear();


                // Update button states
                btnTSAdd.Enabled = false;
                btnTSUpdate.Enabled = false;
                btnTSDelete.Enabled = false;
                btnTSSave.Enabled = true;
                btnTSCancel.Enabled = true;

                // Display instructions
                MessageBox.Show("To update a specification, select the Product ID and enter the Tech Name, then modify the details as needed.",
                    "Update Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in update operation: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTSCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide the input panel
                pnTSInput.Visible = false;
                ucTS_input.Visible = false;

                // Reset input fields
                if (ucTS_input != null)
                {
                    ucTS_input.cbTS_ProductID.SelectedIndex = -1;
                    ucTS_input.txtTS_Tech_name.Clear();
                    ucTS_input.txtTS_Details.Clear();

                }

                // Reset button states
                btnTSAdd.Enabled = true;
                btnTSUpdate.Enabled = true;
                btnTSDelete.Enabled = true;
                btnTSSave.Enabled = false;
                btnTSCancel.Enabled = false;

                // Reset the add flag
                add = false;

                // Disable input fields to prevent further editing until an operation is selected
                if (ucTS_input != null && ucTS_input.gbInputTS != null)
                {
                    ucTS_input.gbInputTS.Enabled = false;
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

        private void btnTSDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTechSpecs.Rows.Count == 0)
                {
                    MessageBox.Show("No technical specifications available to delete.",
                        "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                add = false;

                pnTSInput.Visible = true;

                // Initialize the input control if not already added to panel
                if (!pnTSInput.Controls.Contains(ucTS_input))
                {
                    pnTSInput.Controls.Add(ucTS_input);
                    ucTS_input.Dock = DockStyle.Fill;
                }

                // Show the input control
                ucTS_input.Visible = true;

                // Make sure the product ID combobox is populated
                ucTS_input.LoadProductModelID();

                // enable the ComboBox and txtTechName for selecting the product ID
                ucTS_input.gbInputTS.Enabled = true;
                ucTS_input.cbTS_ProductID.Enabled = true;
                ucTS_input.txtTS_Tech_name.Enabled = true;
                ucTS_input.txtTS_Details.Enabled = false;

                // Update button states
                btnTSAdd.Enabled = false;
                btnTSUpdate.Enabled = false;
                btnTSDelete.Enabled = false;
                btnTSSave.Enabled = true;  // Enable save button for deletion confirmation
                btnTSCancel.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTSSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (ucTS_input.cbTS_ProductID.SelectedIndex < 0 || ucTS_input.cbTS_ProductID.SelectedValue == null)
                {
                    MessageBox.Show("Please select a product ID.", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ucTS_input.cbTS_ProductID.Focus();
                    return;
                }

                // Get values from input fields
                string productId = ucTS_input.cbTS_ProductID.SelectedValue.ToString();
                string techName = ucTS_input.txtTS_Tech_name.Text.Trim();
                string details = ucTS_input.txtTS_Details.Text.Trim();

                bool result = false;

                // For add and update operations, validate tech name and details
                if (add || (ucTS_input.txtTS_Tech_name.Enabled && ucTS_input.txtTS_Details.Enabled))
                {
                    if (string.IsNullOrWhiteSpace(techName))
                    {
                        MessageBox.Show("Technical specification name cannot be empty.", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ucTS_input.txtTS_Tech_name.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(details))
                    {
                        MessageBox.Show("Technical specification details cannot be empty.", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ucTS_input.txtTS_Details.Focus();
                        return;
                    }
                }

                // Perform appropriate operation based on mode
                if (add) // Add new technical specification
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to add this technical specification?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        result = TS.AddTechSpecs(techName, productId, details, ref err);

                        if (result)
                        {
                            MessageBox.Show("Technical specification added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add technical specification: " + err, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        return; // User canceled
                    }
                }
                else // Update or delete based on field state
                {
                    if (!ucTS_input.txtTS_Details.Enabled) // Delete mode
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to delete this technical specification?",
                            "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {
                            // Get the tech_name from the combobox selection or other source
                            if (string.IsNullOrWhiteSpace(techName))
                            {
                                MessageBox.Show("Please select a valid technical specification to delete.",
                                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            result = TS.DeleteTechSpecs(techName, productId, ref err);

                            if (result)
                            {
                                MessageBox.Show("Technical specification deleted successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete technical specification: " + err, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            return; // User canceled
                        }
                    }
                    else // Update mode
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to update this technical specification?",
                            "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            result = TS.UpdateTechSpecs(techName, productId, details, ref err);

                            if (result)
                            {
                                MessageBox.Show("Technical specification updated successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to update technical specification: " + err, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            return; // User canceled
                        }
                    }
                }

                // After successful operation, reset UI
                pnTSInput.Visible = false;

                // Reset button states
                btnTSAdd.Enabled = true;
                btnTSUpdate.Enabled = true;
                btnTSDelete.Enabled = true;
                btnTSSave.Enabled = false;
                btnTSCancel.Enabled = false;

                // Disable input controls
                ucTS_input.gbInputTS.Enabled = false;

                // Refresh the data
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during save operation: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
