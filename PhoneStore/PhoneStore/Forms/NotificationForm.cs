using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneStore.Business;

namespace PhoneStore.Forms
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        Notification bn = new Notification();

        //FOR DRAGGING
        private bool dragging = false; //check if the mouse is in dragging state
        private Point dragCursorPoint; //save the current pos of the mouse
        private Point dragFormPoint;   //save the current pos of the form

        private void topPN_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true; //in dragging state
            dragCursorPoint = System.Windows.Forms.Cursor.Position; //update cursor pos
            dragFormPoint = this.Location; //update form pos
        }

        private void topPN_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                //calculate the displacement between init pos and current pos
                Point dif = Point.Subtract(System.Windows.Forms.Cursor.Position, new Size(dragCursorPoint));
                //add the displacement into the location of the form
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void topPN_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            LoadNoti();
        }

        private void LoadNoti()
        {
            string noti = "";
            int no = 1;
            DataSet ds = bn.GetAllNotification();
            DataTable dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows) {
                noti += no++ + ") " + row[0].ToString() + "\n";
            }
            lblShow.Text = noti;
        }
    }
}
