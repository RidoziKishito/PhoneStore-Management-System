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
    public partial class ucWarranty : UserControl
    {
        public ucWarranty()
        {
            InitializeComponent();
            LoadData();
            ucWarr_input.gbInputWarr.Enabled = false;
        }
        #region Initialization
        Warranty Warr=new Warranty();
        DataTable dt;
        DataSet ds;
        ucWarranty_input ucWarr_input = new ucWarranty_input();
        string err = " ";
        int uc = 2;
        bool add;
        #endregion
        private void LoadData()
        {
            try
            {
                // Check if dgvTechSpecs is initialized
                if (dgvWarranty == null)
                {
                    MessageBox.Show("Error: DataGridView not initialized.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if TS is initialized
                if (Warr == null)
                {
                    Warr = new Warranty();
                }

                // Get technical specifications data
                dt = Warr.GetWarranty();
                dgvWarranty.AllowUserToAddRows = false;

                // Check if data was retrieved
                if (dt == null)
                {
                    MessageBox.Show("No data retrieved from database.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dt = new DataTable(); // Create empty table to avoid null reference
                }

                // Bind data to the DataGridView
                dgvWarranty.DataSource = dt;

                // Reset input fields if ucTS_input is initialized
                if (ucWarr_input != null)
                {
                    // Reset your specific input fields here, for example:
                    ucWarr_input.txtWarr_detail.ResetText();
                    ucWarr_input.txtWarr_name.ResetText();
                    ucWarr_input.txtWarr_duration.ResetText();

                }

                // Enable/Disable buttons
                
                if (btnWarrAdd != null) btnWarrAdd.Enabled = true;
                if (btnWarrDelete != null) btnWarrDelete.Enabled = true;
                if (btnWarrSave != null) btnWarrSave.Enabled = false;
                if (btnWarrCancel != null) btnWarrCancel.Enabled = false;

                // Disable input fields
                if (ucWarr_input != null && ucWarr_input.gbInputWarr != null)
                {
                    ucWarr_input.gbInputWarr.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Warranty data: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnWarrSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate data based on operation type
                if (add)
                {
                    // For Add operation - validate all fields
                    if (string.IsNullOrWhiteSpace(ucWarr_input.txtWarr_name.Text))
                    {
                        MessageBox.Show("Warranty name cannot be empty.", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ucWarr_input.txtWarr_name.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(ucWarr_input.txtWarr_detail.Text))
                    {
                        MessageBox.Show("Warranty details cannot be empty.", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ucWarr_input.txtWarr_detail.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(ucWarr_input.txtWarr_duration.Text))
                    {
                        MessageBox.Show("Warranty duration cannot be empty.", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ucWarr_input.txtWarr_duration.Focus();
                        return;
                    }

                    // Validate that duration is a number
                    int duration;
                    if (!int.TryParse(ucWarr_input.txtWarr_duration.Text.Trim(), out duration))
                    {
                        MessageBox.Show("Warranty duration must be a valid number.", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ucWarr_input.txtWarr_duration.Focus();
                        return;
                    }
                }
                else // Delete operation
                {
                    // Ensure a warranty ID is selected for deletion
                    if (ucWarr_input.cbWarr_WarrantyID.SelectedIndex < 0 ||
                        ucWarr_input.cbWarr_WarrantyID.SelectedValue == null)
                    {
                        MessageBox.Show("Please select a warranty to delete.", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ucWarr_input.cbWarr_WarrantyID.Focus();
                        return;
                    }
                }

                bool result = false;
                string message = "";

                // Perform database operation based on mode
                if (add) // Add new warranty
                {
                    string warrantyName = ucWarr_input.txtWarr_name.Text.Trim();
                    string warrantyDetail = ucWarr_input.txtWarr_detail.Text.Trim();
                    int warrantyDuration = int.Parse(ucWarr_input.txtWarr_duration.Text.Trim());

                    DialogResult dr = MessageBox.Show("Are you sure you want to add this new warranty?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        // Convert duration string to int for the method call
                        result = Warr.AddWarranty(warrantyName, warrantyDetail, warrantyDuration, ref err);
                        message = "Warranty added successfully!";
                    }
                    else
                    {
                        return; // User canceled
                    }
                }
                else // Delete warranty
                {
                    string warrantyId = ucWarr_input.cbWarr_WarrantyID.SelectedValue.ToString();

                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this warranty? This action cannot be undone.",
                        "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        result = Warr.DeleteWarranty(warrantyId, ref err);
                        message = "Warranty deleted successfully!";
                    }
                    else
                    {
                        return; // User canceled
                    }
                }

                // Display result message
                if (result)
                {
                    MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hide the input panel
                    pnWarrantyInput.Visible = false;
                    ucWarr_input.Visible = false;

                    // Reset button states
                    btnWarrAdd.Enabled = true;
                    btnWarrDelete.Enabled = true;
                    btnWarrSave.Enabled = false;
                    btnWarrCancel.Enabled = false;

                    // Disable input group box
                    ucWarr_input.gbInputWarr.Enabled = false;

                    // Refresh the data
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Operation failed: " + err, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during save operation: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWarrCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide the input panel
                pnWarrantyInput.Visible = false;
                ucWarr_input.Visible = false;

                // Reset input fields
                if (ucWarr_input != null)
                {
                    ucWarr_input.cbWarr_WarrantyID.SelectedIndex = -1;
                    ucWarr_input.txtWarr_detail.Clear();
                    ucWarr_input.txtWarr_duration.Clear();

                }

                // Reset button states
                btnWarrAdd.Enabled = true;
                btnWarrDelete.Enabled = true;
                btnWarrSave.Enabled = false;
                btnWarrCancel.Enabled = false;

                // Reset the add flag
                add = false;

                // Disable input fields to prevent further editing until an operation is selected
                if (ucWarr_input != null && ucWarr_input.gbInputWarr != null)
                {
                    ucWarr_input.gbInputWarr.Enabled = false;
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

        private void btnWarrAdd_Click(object sender, EventArgs e)
        {
            // Set mode flag
            add = true;

            // Show panel and input control
            pnWarrantyInput.Visible = true;

            // Initialize the input control if not already added to panel
            if (!pnWarrantyInput.Controls.Contains(ucWarr_input))
            {
                pnWarrantyInput.Controls.Add(ucWarr_input);
                ucWarr_input.Dock = DockStyle.Fill;
            }

            // Show the input control
            ucWarr_input.Visible = true;

            // Clear input fields
            ucWarr_input.txtWarr_detail.Clear();
            ucWarr_input.txtWarr_name.Clear();
            ucWarr_input.cbWarr_WarrantyID.Enabled = false;

            ucWarr_input.txtWarr_duration.Clear();

            // Enable the GroupBox
            ucWarr_input.gbInputWarr.Enabled = true;

            // Update button states
            btnWarrAdd.Enabled = false;

            btnWarrDelete.Enabled = false;
            btnWarrSave.Enabled = true;
            btnWarrCancel.Enabled = true;
        }

        private void btnWarrDelete_Click(object sender, EventArgs e)
        {
            try
            {
                add = false;

                pnWarrantyInput.Visible = true;

                // Initialize the input control if not already added to panel
                if (!pnWarrantyInput.Controls.Contains(ucWarr_input))
                {
                    pnWarrantyInput.Controls.Add(ucWarr_input);
                    ucWarr_input.Dock = DockStyle.Fill;
                }

                // Show the input control
                ucWarr_input.Visible = true;

                // Make sure the product ID combobox is populated
                ucWarr_input.LoadWarrantyID();

                // Only enable the ComboBox for selecting the product ID
                ucWarr_input.gbInputWarr.Enabled = true;
                ucWarr_input.cbWarr_WarrantyID.Enabled = true;
                ucWarr_input.txtWarr_detail.Enabled = false;
                ucWarr_input.txtWarr_name.Enabled = false;
                
                ucWarr_input.txtWarr_duration.Enabled = false;

                // Update button states
                btnWarrAdd.Enabled = false;
                
                btnWarrDelete.Enabled = false;
                btnWarrSave.Enabled = true;  // Enable save button for deletion confirmation
                btnWarrCancel.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWarrReload_Click(object sender, EventArgs e)
        {
            LoadData();
            ucWarr_input.LoadWarrantyID();
        }
    }
}
