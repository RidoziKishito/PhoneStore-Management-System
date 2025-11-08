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
    public partial class ucCustomerForAdmin : UserControl
    {
        public ucCustomerForAdmin()
        {
            InitializeComponent();
        }
        bool isAdd = false;
        private void LoadData()
        {
            try
            {
                DataTable dt = Customer.GetCustomerByPhoneNumber("");

                // Đưa dữ liệu lên DataGridView   
                dgv_Customer.DataSource = dt;

                btn_Save.Enabled = false;
                btn_Cancle.Enabled = false;
                txt_ID.Enabled = false; // Không cho phép sửa ID
                txt_Name.Enabled = false; // Không cho phép sửa Name
                txt_Email.Enabled = false; // Không cho phép sửa Email
                isAdd = false; // Đặt trạng thái là không thêm mới

                txt_ID.ResetText();
                txt_Name.ResetText();
                txt_PhoneNumber.ResetText();
                txt_Email.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành  
            int r = dgv_Customer.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel  
            var data = dgv_Customer.Rows[r];
            // Lấy thông tin từ dòng đã chọn
            // Chuyển thông tin lên panel
            txt_ID.Text = data.Cells["CustomerID"].Value.ToString();
            txt_Name.Text = data.Cells["CustomerName"].Value.ToString();
            txt_PhoneNumber.Text = data.Cells["PhoneNumber"].Value.ToString();
            txt_Email.Text = data.Cells["Email"].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string error = "";
                DialogResult ans;
                ans = MessageBox.Show("Are you sure to delete?", "Answer",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ans == DialogResult.OK)
                {
                    if (Customer.DeleteCustomer(txt_ID.Text.Trim(), ref error))
                    {
                        MessageBox.Show("Customer deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show(error, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                LoadData();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            isAdd = true;
            btn_Save.Enabled = true;
            btn_Cancle.Enabled = true;
            txt_Name.Enabled = true; // Cho phép sửa Name
            txt_Email.Enabled = true; // Cho phép sửa Email
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            isAdd = false;
            btn_Save.Enabled = true;
            btn_Cancle.Enabled = true;
            txt_Name.Enabled = true; // Cho phép sửa Name
            txt_Email.Enabled = true; // Cho phép sửa Email
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string error = "";
            if (isAdd)
            {
                try
                {
                    if (Customer.InsertCustomer(txt_Name.Text.Trim(), txt_PhoneNumber.Text.Trim(), txt_Email.Text.Trim(), ref error))
                    {
                        MessageBox.Show("Customer inserted successfully!");
                    }
                    else
                    {
                        MessageBox.Show(error, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    LoadData();
                }
            }
            else
            {
                // Cập nhật thông tin khách hàng
                try
                {
                    if (Customer.UpdateCustomer(txt_ID.Text.Trim(), txt_Name.Text.Trim(), txt_PhoneNumber.Text.Trim(), txt_Email.Text.Trim(), ref error))
                    {
                        MessageBox.Show("Customer updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show(error, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    LoadData();
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = txt_PhoneNumber.Text.Trim();
                DataTable dt = Customer.GetCustomerByPhoneNumber(phone);
                dgv_Customer.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No customer found with this phone number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
