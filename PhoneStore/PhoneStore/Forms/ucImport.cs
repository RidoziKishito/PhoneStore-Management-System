using PhoneStore.AdditionalFunctions;
using PhoneStore.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PhoneStore.Forms
{
    public partial class ucImport : UserControl
    {
        public ucImport()
        {
            InitializeComponent();
            importOrder.AddedTVP += ucImport_Order_AddedTVP;
        }

        #region Initialization

        DataTable dt;
        DataSet ds;

        ucImport_Supplier supplier = new ucImport_Supplier();
        Supplier bsp = new Supplier();

        ucImport_Order importOrder = new ucImport_Order();
        ImportOrder bio = new ImportOrder();

        Temporary tmpBL = new Temporary();

        string err = "";
        int uc = 0;
        bool add;
        bool isAdding = false;

        #endregion

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                supplier.gbInput.Enabled = true;
                if (add)
                {
                    if (uc == 1)
                    {
                        if (importOrder.cbSuppliers.SelectedItem != null)
                        {

                            DataRowView selectedRow = (DataRowView)importOrder.cbSuppliers.SelectedItem;
                            importOrder.txtSupplierName.Text = selectedRow[0].ToString() + " - " + selectedRow[1].ToString();

                            GlobalState.total_product = 0;
                            importOrder.txtTotal.Text = GlobalState.total_product.ToString();
                            importOrder.gbDetail.Enabled = true;
                            importOrder.gbImportOrder.Enabled = false;
                            LoadProductNames();
                            isAdding = false;
                        }
                        else
                        {
                            throw new Exception("Please input all the required information!");
                        }
                    }
                    if (uc == 2)
                    {
                        if (!String.IsNullOrEmpty(supplier.txtName.Text) && !String.IsNullOrEmpty(supplier.txtPhoneNumber.Text) && !String.IsNullOrEmpty(supplier.txtAddress.Text) &&
                            bsp.AddSupplier(supplier.txtName.Text, supplier.txtPhoneNumber.Text, supplier.txtAddress.Text, ref err))
                        {
                            MessageBox.Show("Add succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("Please input all the required information!");
                        }
                    }
                    LoadData();
                    supplier.gbInput.Enabled = false;
                }
                else
                {
                    if (uc == 2)
                    {
                        string id = dgvDisplay.SelectedRows[0].Cells[0].Value.ToString();
                        bsp.UpdateSupplier(id, supplier.txtName.Text, supplier.txtPhoneNumber.Text, supplier.txtAddress.Text, ref err);
                        LoadData();
                        MessageBox.Show("Update succesfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(err))
                {
                    MessageBox.Show("SQL Error: " + err, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("App Error: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                supplier.gbInput.Enabled = false;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (uc == 1)
            {
                importOrder.ResetInput();
                isAdding = false;
            }
            if (uc == 2)
            {
                supplier.txtName.ResetText();
                supplier.txtPhoneNumber.ResetText();
                supplier.txtAddress.ResetText();
            }
            // Enable other buttons
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;

            // Enable Save and Cancel
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            supplier.gbInput.Enabled = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ""; 

                // Lấy thứ tự record hiện hành
                int r = dgvDisplay.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành

                id = dgvDisplay.Rows[r].Cells[0].Value.ToString();


                DialogResult answer;
                // Hiện hộp thoại hỏi đáp
                answer = MessageBox.Show("Do you want to delete this row?", "Anwser?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (answer == DialogResult.Yes)
                {
                    if (uc == 1)
                        bio.DeleteImportOrder(id, ref err);
                    if (uc == 2)
                        bsp.DeleteSupplier(id, ref err);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    if (err != "")
                        MessageBox.Show("Cannot delete: " + err);
                    else
                        MessageBox.Show("Delete successfully!");
                }
                else
                {
                    MessageBox.Show("Canceled delete the row!");
                }
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(err))
                {
                    MessageBox.Show("SQL Error: " + err, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("App Error: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                isAdding = true;
                supplier.gbInput.Enabled = true;
                if (uc == 1)
                {
                    importOrder.gbImportOrder.Enabled = true;
                    LoadSupplierNames();
                }
                else if (uc == 2)
                {
                    // Reset text box
                    supplier.txtName.ResetText();
                    supplier.txtPhoneNumber.ResetText();
                    supplier.txtAddress.ResetText();
                }
                add = true;
                // Unable other buttons
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Enabled = false;
                // Enable Save and Cancel
                btnSave.Enabled = true;
                btnCancel.Enabled = true;

                importOrder.dgvDetail.Rows.Clear();
                importOrder.dgvDetail.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDisplay.SelectedRows.Count > 0)
            {
                supplier.gbInput.Enabled = true;
                if (uc == 2)
                {
                    add = false;
                    // Enable & Reset text box
                    supplier.txtName.ResetText();
                    supplier.txtPhoneNumber.ResetText();
                    supplier.txtAddress.ResetText();
                    // Unable other buttons
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnAdd.Enabled = false;
                    // Enable Save and Cancel
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please chooose a supplier (Clink on the left-side bar) !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            supplier.LoadSupplierNames();
        }
        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvDisplay.Rows[e.RowIndex];
                    if (uc == 1)
                    {
                        if (!isAdding)
                        {
                            DataSet ds = bio.GetImportOrderDetail(row.Cells[0].Value?.ToString());
                            DataTable data = ds.Tables[0];
                            importOrder.dgvDetail.Rows.Clear();
                            foreach (DataRow DataRow in data.Rows)
                            {
                                importOrder.dgvDetail.Rows.Add(DataRow.ItemArray);
                            }
                            importOrder.dgvDetail.Refresh();
                        }
                    }
                    else if (uc == 2)
                    {
                        supplier.txtName.Text = row.Cells[1].Value?.ToString();
                        supplier.txtPhoneNumber.Text = row.Cells[2].Value?.ToString();
                        supplier.txtAddress.Text = row.Cells[3].Value?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ucImport_Load(object sender, EventArgs e)
        {
            LoadData();
            AddPicture();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                AddUserControl(importOrder);
                uc = 1;
                LoadData();
                importOrder.ResetInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                AddUserControl(supplier);
                uc = 2;
                LoadData();
                supplier.ResetInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AddPicture();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbView.SelectedIndex != -1)
                {
                    string cmd = cbView.Text;
                    switch (cmd)
                    {
                        case "Show all suppliers":
                            ds = bsp.GetAllSupplier();
                            break;
                        case "Show all products imported by a supplier":
                            string supId = supplier.cbSuppliers.Text?.Split('-')[0].Trim();
                            ds = bsp.GetProductOfSupplier(supId);
                            break;
                        case "Show all import orders in this month":
                            ds = bio.GetImportOrderInMonth();
                            break;
                        default:
                            throw new Exception("Please choose a valid value!!");
                    }
                    dt = ds.Tables[0];
                    dgvDisplay.DataSource = dt;
                    dgvDisplay.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Functions

        public void LoadProductNames()
        {
            DataSet dsProduct = tmpBL.GetAllProductName();
            if (dsProduct != null && dsProduct.Tables.Count > 0)
            {
                dt = dsProduct.Tables[0];

                dt.Columns.Add("Display", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    row["Display"] = row[0] + " - " + row[1];
                }

                importOrder.cbProduct.DataSource = dt;
                importOrder.cbProduct.DisplayMember = "Display";
            }
        }

        public void LoadSupplierNames()
        {
            DataSet dsSupplier = bsp.GetAllSupplierName();
            if (dsSupplier != null && dsSupplier.Tables.Count > 0)
            {
                dt = dsSupplier.Tables[0];

                dt.Columns.Add("Display", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    row["Display"] = row[0] + " - " + row[1];
                }

                importOrder.cbSuppliers.DataSource = dt;
                importOrder.cbSuppliers.DisplayMember = "Display";
            }
        }
        private void AddUserControl(UserControl usercontrol)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        public void LoadData()
        {
            dt = new DataTable();
            dt.Clear();
            if (uc == 1) ds = bio.GetAllImportOrder();
            else if (uc == 2) ds = bsp.GetAllSupplier();
            if (uc != 0)
            {
                dt = ds.Tables[0];
                dgvDisplay.DataSource = dt;
            }

            // Reset text box
            supplier.txtName.ResetText();
            supplier.txtPhoneNumber.ResetText();
            supplier.txtAddress.ResetText();

            // Enable other buttons
            if (uc == 1)
                btnUpdate.Enabled = false;
            else btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;

            // Enable Save and Cancel
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            // Refresh display
            dgvDisplay.Refresh();

            // Load view comboBox
            cbView.Items.Clear();
            if (uc == 1)
            {
                cbView.Items.AddRange(new string[] {
                "Show all import orders in this month"});
            }
            else if (uc == 2)
            {
                cbView.Items.AddRange(new string[] {
                "Show all suppliers",
                "Show all products imported by a supplier"});
            }
        }

        private void ucImport_Order_AddedTVP(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddPicture()
        {
            PictureBox mainPic = new PictureBox();
            mainPic.Size = new Size(510, 662); // Set size
            mainPic.Location = new Point(10, 10); // Set position
            mainPic.Image = Properties.Resources.warehousemanagement;
            mainPic.SizeMode = PictureBoxSizeMode.Zoom;

            pnMain.Controls.Clear();
            pnMain.Controls.Add(mainPic);
            pnMain.Refresh();
        }


        #endregion

    }
}
