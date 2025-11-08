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
    public partial class ucTech_Specs_input : UserControl
    {
        public ucTech_Specs_input()
        {
            InitializeComponent();
        }
        private Technical_Specs TS = new Technical_Specs();
        DataTable dt;
        public void LoadProductModelID()
        {
            try
            {
                DataTable dt = TS.GetProduct_Model_IDs();
                if (dt.Rows.Count > 0)
                {
                    cbTS_ProductID.DataSource = dt;
                    cbTS_ProductID.DisplayMember = "product_id";
                    cbTS_ProductID.ValueMember = "product_id";
                    cbTS_ProductID.SelectedIndex = -1;
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
        private void ucTech_Specs_input_Load(object sender, EventArgs e)
        {
            LoadProductModelID();
        }
    }
}
