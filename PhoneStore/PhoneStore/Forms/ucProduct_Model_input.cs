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
    public partial class ucProduct_Model_input : UserControl
    {
        public ucProduct_Model_input()
        {
            InitializeComponent();
        }
        private ProductModel pm = new ProductModel();
        DataTable dt;
        public void LoadProductModelID()
        {
            try
            {
                DataTable dt = pm.GetProduct_Model_IDs();
                if (dt.Rows.Count > 0)
                {
                    cbPM_ProductID.DataSource = dt;
                    cbPM_ProductID.DisplayMember = "product_id";
                    cbPM_ProductID.ValueMember = "product_id";
                    cbPM_ProductID.SelectedIndex = -1;
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

        private void ucProduct_Model_input_Load(object sender, EventArgs e)
        {
            LoadProductModelID();
        }

    }
}
