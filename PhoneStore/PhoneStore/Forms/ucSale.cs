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
    public partial class ucSale : UserControl
    {
        public ucSale()
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
            pnUserControls.Controls.Clear();
            pnUserControls.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        #endregion

        #region 3) Functions
        private void btnPromotion_Click(object sender, EventArgs e)
        {
            ucPromotion Promotion = new ucPromotion();
            addUserControl(Promotion);
            lblIcon.Text = "Sale - Promotion";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ucOrder Order = new ucOrder();
            addUserControl(Order);
            lblIcon.Text = "Sale - Order";
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            //ucOrderDetail OrderDetail = new ucOrderDetail();
            //addUserControl(OrderDetail);
            lblIcon.Text = "Sale Order";
        }
        #endregion

        private void ucSale_Load(object sender, EventArgs e)
        {
            AddPicture();
        }
        private void AddPicture()
        {
            PictureBox mainPic = new PictureBox();
            mainPic.Size = new Size(1384, 766); // Set size
            mainPic.Location = new Point(10, 10); // Set position
            mainPic.Image = Properties.Resources.sale;
            mainPic.SizeMode = PictureBoxSizeMode.Zoom;

            pnUserControls.Controls.Clear();
            pnUserControls.Controls.Add(mainPic);
            pnUserControls.Refresh();
        }

    }
}
