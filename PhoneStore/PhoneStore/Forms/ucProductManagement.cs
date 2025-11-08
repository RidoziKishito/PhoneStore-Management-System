using PhoneStore.Database;
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
    public partial class ucProductManagement : UserControl
    {
        public ucProductManagement()
        {
            InitializeComponent();
        }
        #region 1) Initialization

        //FOR DRAGGING
        private bool dragging = false; //check if the mouse is in dragging state
        private Point dragCursorPoint; //save the current pos of the mouse
        private Point dragFormPoint;   //save the current pos of the form

        #endregion

        #region 2) Window settings

        private void addUserControl(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            pnProductUserCtrl.Controls.Clear();
            pnProductUserCtrl.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        #endregion

        #region 3) Buttons
        private void btnProductModel_Click(object sender, EventArgs e)
        {
            ucProductModel ucProductModel = new ucProductModel();
            addUserControl(ucProductModel);
        }
        private void btnTechnical_Specification_Click(object sender, EventArgs e)
        {
            ucTechnical_Spec ucTechnical_Spec = new ucTechnical_Spec();
            addUserControl(ucTechnical_Spec);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ucProduct ucProduct = new ucProduct();
            addUserControl(ucProduct);
        }

        private void btnWarranty_Click(object sender, EventArgs e)
        {
            ucWarranty ucwarranty = new ucWarranty();
            addUserControl(ucwarranty);
        }

        #endregion

        private void ucProductManagement_Load(object sender, EventArgs e)
        {
            AddPicture();
        }

        private void AddPicture()
        {
            PictureBox mainPic = new PictureBox();
            mainPic.Size = new Size(1384, 694); // Set size
            mainPic.Location = new Point(10, 10); // Set position
            mainPic.Image = Properties.Resources.product_management;
            mainPic.SizeMode = PictureBoxSizeMode.Zoom;

            pnProductUserCtrl.Controls.Clear();
            pnProductUserCtrl.Controls.Add(mainPic);
            pnProductUserCtrl.Refresh();
        }
    }
}
