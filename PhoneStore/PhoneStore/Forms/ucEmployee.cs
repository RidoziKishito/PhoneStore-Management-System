using GMap.NET.MapProviders;
using PhoneStore.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneStore.Business;

namespace PhoneStore.Forms
{
    public partial class ucEmployee : UserControl
    {
        public ucEmployee()
        {
            InitializeComponent();
        }
        bool isAdd = false;
        private void LoadData()
        {
            try
            {
                // Gán dữ liệu cho ComboBox
                cb_Position.DataSource = Employee.GetAllEmployeePosition();
                cb_Position.ValueMember = "position"; // Giá trị thực tế
                cb_Position.DisplayMember = "position"; // Giá trị hiển thị

                btn_Save.Enabled = false;
                btn_Cancle.Enabled = false;
                txt_ID.Enabled = false; // Không cho phép sửa ID
                txt_Name.Enabled = false; // Không cho phép sửa Name
                txt_PhoneNumber.Enabled = false; // Không cho phép sửa PhoneNumber
                isAdd = false; // Đặt trạng thái là không thêm mới

                txt_ID.ResetText();
                txt_Name.ResetText();
                txt_PhoneNumber.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ucEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cb_Position_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị của ComboBox
                string selectedPosition = cb_Position.SelectedValue.ToString();
                // Lọc dữ liệu theo vị trí đã chọn
                DataTable dt = Employee.GetEmployeeByPosition(selectedPosition);
                // Đưa dữ liệu lên DataGridView
                dgv_Employee.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgv_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành  
            int r = dgv_Employee.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel  
            var data = dgv_Employee.Rows[r];
            // Lấy thông tin từ dòng đã chọn
            // Chuyển thông tin lên panel
            txt_ID.Text = data.Cells["EmployeeID"].Value.ToString();
            txt_Name.Text = data.Cells["EmployeeName"].Value.ToString();
            txt_PhoneNumber.Text = data.Cells["PhoneNumber"].Value.ToString();
            cb_Position.Text = data.Cells["position"].Value.ToString();
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
                    if (Employee.DeleteEmployee(txt_ID.Text.Trim(), ref error))
                    {
                        MessageBox.Show("Employee deleted successfully!");
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
            txt_PhoneNumber.Enabled = true; // Cho phép sửa PhoneNumber
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            isAdd = false;
            btn_Save.Enabled = true;
            btn_Cancle.Enabled = true;
            txt_Name.Enabled = true; // Cho phép sửa Name
            txt_PhoneNumber.Enabled = true; // Cho phép sửa PhoneNumber
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
                    if (Employee.InsertEmployee(txt_Name.Text.Trim(), txt_PhoneNumber.Text.Trim(), cb_Position.Text.Trim(), ref error))
                    {
                        MessageBox.Show("Employee inserted successfully!");
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
                // Cập nhật thông tin nhân viên
                try
                {
                    if (Employee.UpdateEmployee(txt_ID.Text.Trim(), txt_Name.Text.Trim(), txt_PhoneNumber.Text.Trim(), cb_Position.Text.Trim(), ref error))
                    {
                        MessageBox.Show("Employee updated successfully!");
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
    }
}
