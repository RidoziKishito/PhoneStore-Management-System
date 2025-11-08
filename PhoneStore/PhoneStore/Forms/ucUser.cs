using PhoneStore.AdditionalFunctions;
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
    public partial class ucUser : UserControl
    {
        public ucUser()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            pnUserControls.Controls.Clear();
            pnUserControls.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void lbl_Employee_Click(object sender, EventArgs e)
        {
            if(Session.CurrentRole != "Admin")
            {
                MessageBox.Show("You don't have permission to access this function");
                return;
            }
            if(Session.CurrentRole == "Admin")
            {
                ucEmployee ucEmployee = new ucEmployee();
                addUserControl(ucEmployee);
            }
        }

        private void lbl_Customer_Click(object sender, EventArgs e)
        {
            ucCustomerForAdmin ucCustomer = new ucCustomerForAdmin();
            addUserControl(ucCustomer);
        }
    }
}
