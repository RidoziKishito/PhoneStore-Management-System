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
    public partial class ucProduct_input : UserControl
    {
        public ucProduct_input()
        {
            InitializeComponent();
        }
        private Product p = new Product();
        DataTable dt;
        public void LoadPM_ID_and_Warr_ID()
        {
            try
            {
                // Load Product Model IDs for the first combo box
                DataTable dt = p.GetProduct_Model_IDs();
                if (dt.Rows.Count > 0)
                {
                    cbP_ProductID.DataSource = dt;
                    cbP_ProductID.DisplayMember = "product_id";
                    cbP_ProductID.ValueMember = "product_id";
                    cbP_ProductID.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu Product Model.");
                }

                // Load Warranty IDs for the second combo box
                DataTable dt2 = p.GetWarrantyIDs(); // Changed to correct method name without underscore
                if (dt2.Rows.Count > 0) // Check dt2, not dt
                {
                    cbP_warranty_id.DataSource = dt2;
                    cbP_warranty_id.DisplayMember = "warranty_id";
                    cbP_warranty_id.ValueMember = "warranty_id";
                    cbP_warranty_id.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu Warranty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void ucProduct_input_Load(object sender, EventArgs e)
        {
            LoadPM_ID_and_Warr_ID();
        }

        
    }
}
