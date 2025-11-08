using PhoneStore.AdditionalFunctions;
using PhoneStore.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneStore.Forms;
using PhoneStore.Business;

namespace PhoneStore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        #region 1) Initialization

        //FOR DRAGGING
        private bool dragging = false; //check if the mouse is in dragging state
        private Point dragCursorPoint; //save the current pos of the mouse
        private Point dragFormPoint;   //save the current pos of the form
        Notification bn = new Notification();

        #endregion

        #region 2) Window settings
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

        private void addUserControl(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            pnUserControls.Controls.Clear();
            pnUserControls.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        #endregion

        #region 3) Functions
        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timerNoti.Start();
            lblUser.Text = "Hello " + Session.CurrentUser;
            ucDashboard DashBoard = new ucDashboard();
            addUserControl(DashBoard);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            ucDashboard DashBoard = new ucDashboard();
            addUserControl(DashBoard);
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            ucImport Import = new ucImport();
            addUserControl(Import);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ucProductManagement Product = new ucProductManagement();
            addUserControl(Product);
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            ucUser User = new ucUser();
            addUserControl(User);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            ucSale Sale = new ucSale();
            addUserControl(Sale);
        }

        #endregion

        private void pnUserControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerNoti_Tick(object sender, EventArgs e)
        {
            CheckNotification();
        }

        private void CheckNotification()
        {
            try
            {
                if (bn.IsExistNoti())
                {
                    pbYellowBell.Visible = true;
                    pbYellowBell.BringToFront();
                }
                else
                {
                    pbYellowBell.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pbYellowBell_Click(object sender, EventArgs e)
        {
            NotificationForm nf = new NotificationForm();
            nf.ShowDialog();
        }
    }
}
