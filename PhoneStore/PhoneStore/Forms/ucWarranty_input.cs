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
    public partial class ucWarranty_input : UserControl
    {
        public ucWarranty_input()
        {
            InitializeComponent();
        }
        private Warranty warr = new Warranty();
        DataTable dt;
        public void LoadWarrantyID()
        {
            try
            {
                DataTable dt = warr.GetWarrantyIDs();
                if (dt.Rows.Count > 0)
                {
                    cbWarr_WarrantyID.DataSource = dt;
                    cbWarr_WarrantyID.DisplayMember = "warranty_id";
                    cbWarr_WarrantyID.ValueMember = "warranty_id";
                    cbWarr_WarrantyID.SelectedIndex = -1;
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

        private void ucWarranty_input_Load(object sender, EventArgs e)
        {
            LoadWarrantyID();
        }
    }
}
