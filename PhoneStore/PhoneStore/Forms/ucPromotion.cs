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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PhoneStore.Forms
{
    public partial class ucPromotion : UserControl
    {
        public ucPromotion()
        {
            InitializeComponent();
        }
        Promotion pro = new Promotion();
        private void ucPromotion_Load(object sender, EventArgs e)
        {
            LoadPromotions();
            LoadPromotionID();
        }
        private void LoadPromotions()
        {
            dgvPromotions.DataSource = pro.GetAllPromotions();
        }

        private void LoadPromotionID()
        {
            try
            {
                DataTable dt = pro.GetAllPromotions();
                if (dt.Rows.Count > 0)
                {
                    cbPromotionID.DataSource = dt;
                    cbPromotionID.DisplayMember = "promotion_id";
                    cbPromotionID.ValueMember = "promotion_id";
                    cbPromotionID.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No Promotion Data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Promotions: {ex.Message}");
            }
        }

        private void btnAddPromotion_Click(object sender, EventArgs e)
        {
            try
            {
                string error = "";
                bool result = pro.AddPromotion(
                    txtCondition.Text,
                    nudPercentage.Value,
                    dtpStart.Value,
                    dtpEnd.Value,
                    ref error
                );

                if (result)
                {
                    MessageBox.Show("Add successfully!");
                    LoadPromotions();
                }
                else
                {
                    throw new Exception("Error: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }      
        }

        private void btnDeletePromotion_Click(object sender, EventArgs e)
        {
            if (dgvPromotions.CurrentRow == null)
            {
                MessageBox.Show("Please choose a row to delete! (left-side bar)");
                return;
            }
            string id = dgvPromotions.CurrentRow.Cells[0].Value.ToString(); // Hoặc Cells["promotion_id"]
            // Xác nhận xoá
            DialogResult confirmResult = MessageBox.Show(
                $"Confirm deletion: {id}?",
                "Delete confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.No)
                return;
            
            string error = "";

            bool result = pro.DeletePromotion(id, ref error);

            if (result)
            {
                MessageBox.Show("Delete successfully!");
                LoadPromotions();
            }
            else
            {
                MessageBox.Show("Error: " + error);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPromotions.DataSource = pro.GetSaleOrderPromotion(cbPromotionID.Text); // Gọi phương thức kiểm tra từ lớp SaleOrder
                dgvPromotions.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPromotions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
