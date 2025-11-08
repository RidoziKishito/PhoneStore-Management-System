using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using PhoneStore.Business;
using PhoneStore.AdditionalFunctions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace PhoneStore.Forms
{
    public partial class ucImport_Supplier : UserControl
    {
        public ucImport_Supplier()
        {
            InitializeComponent();
        }

        private GMapOverlay markersOverlay;
        private Supplier bsp = new Supplier();
        DataTable dt;
        private void AddMarker(PointLatLng point)
        {
            markersOverlay.Markers.Clear();
            var marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot)
            {
                ToolTipMode = MarkerTooltipMode.OnMouseOver
            };
            markersOverlay.Markers.Add(marker);
            gMapControl1.Position = point;
        }
        private void LoadMap()
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;  // Sử dụng Google Map
            GMaps.Instance.Mode = AccessMode.ServerOnly; // Chế độ online
            gMapControl1.Position = new PointLatLng(10.7769, 106.7009); // Tâm TP.HCM
            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 13; // Mức zoom ban đầu
            gMapControl1.ShowCenter = false;
            markersOverlay = new GMapOverlay("markers");
            gMapControl1.Overlays.Add(markersOverlay);

        }

        public void LoadSupplierNames()
        {
            DataSet dsSupplier = bsp.GetAllSupplierName();
            if (dsSupplier != null && dsSupplier.Tables.Count > 0)
            {
                dt = dsSupplier.Tables[0];

                dt.Columns.Add("Display", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    row["Display"] = row[0] + " - " + row[1];
                }

                cbSuppliers.DataSource = dt;
                cbSuppliers.DisplayMember = "Display";
            }
        }

        private void ucImport_Supplier_Load(object sender, EventArgs e)
        {
            LoadMap();
            LoadSupplierNames();
        }
        private async void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string comboText = cbSuppliers.Text;
                string id = comboText.Split('-')[0].Trim();  // Get ID

                DataSet dsAddress = bsp.GetAddressByID(id);
                if (dsAddress != null && dsAddress.Tables.Count > 0)
                {
                    DataTable dtAddress = dsAddress.Tables[0];

                    if (dtAddress.Rows.Count > 0)
                    {
                        // Get address
                        string address = dtAddress.Rows[0]["Address"].ToString();

                        var point = await Nominatim.GetCoordinatesWithNominatimAsync(address);
                        AddMarker(point.Value);
                    }
                    else
                    {
                        throw new Exception("Address not found!");
                    }
                }
                else
                {
                    throw new Exception("Invalid Supplier!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ResetInput()
        {
            txtName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtAddress.Text = string.Empty;
            gbInput.Enabled = false;
        }
        #region Not implemented functions
        private void gbLocation_Enter(object sender, EventArgs e)
        {

        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void gbInput_Enter(object sender, EventArgs e)
        {

        }
        private void lblAddress_Click(object sender, EventArgs e)
        {

        }
        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }
        private void lblFullName_Click(object sender, EventArgs e)
        {

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
        private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
