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
    public partial class AddPictureForm : Form
    {
        public AddPictureForm()
        {
            InitializeComponent();
        }

        ProductModel P = new ProductModel();
        string err = "";
        private void btnOk_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtPictureName.Text == string.Empty || cbP_ProductID.SelectedIndex == -1) throw new Exception("Please enter all the values!");
                bool res = P.InsertPicture(cbP_ProductID.Text, txtPictureName.Text, ref err);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " | " + err, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadProductModelID()
        {
            try
            {
                DataTable dt = P.GetProduct_Model_IDs();
                if (dt.Rows.Count > 0)
                {
                    cbP_ProductID.DataSource = dt;
                    cbP_ProductID.DisplayMember = "product_id";
                    cbP_ProductID.ValueMember = "product_id";
                    cbP_ProductID.SelectedIndex = -1;
                    cbP_ProductID.Refresh();
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

        private void gbAddPicture_Enter(object sender, EventArgs e)
        {
            LoadProductModelID();
        }
    }
}
