using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneStore.AdditionalFunctions;
using PhoneStore.Database;
using PhoneStore.Business;

namespace PhoneStore.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text.Trim();
            string password = txt_Password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter complete information!");
                return;
            }
            string error = "";
            try
            {
                if (Login.VerifyLogin(username, password, out error))
                {
                    // Login successful
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Login failed! " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if Enter key was pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Call the login button click event
                btn_Login_Click(this, EventArgs.Empty);

                // Mark the event as handled
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                // Call the login button click event
                this.Close();
            }
        }

        private void txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if Enter key was pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Call the login button click event
                btn_Login_Click(this, EventArgs.Empty);

                // Mark the event as handled
                e.Handled = true;
            }
            if(e.KeyChar == (char)Keys.Escape)
            {
                // Call the login button click event
                this.Close();
            }
        }
    }
}