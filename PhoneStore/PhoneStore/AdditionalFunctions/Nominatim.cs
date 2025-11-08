using GMap.NET;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStore.AdditionalFunctions
{
    public static class Nominatim
    {
        public static async Task<PointLatLng?> GetCoordinatesWithNominatimAsync(string address)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("gmap-winforms-demo");

                string url = $"https://nominatim.openstreetmap.org/search?q={Uri.EscapeDataString(address)}&format=json&limit=1";

                try
                {
                    var response = await client.GetAsync(url);
                    string content = await response.Content.ReadAsStringAsync();

                    JArray json = JArray.Parse(content);
                    if (json.Count > 0)
                    {
                        var result = json[0];
                        double lat = double.Parse(result["lat"].ToString());
                        double lon = double.Parse(result["lon"].ToString());
                        return new PointLatLng(lat, lon);
                    }
                    else
                    {
                        //MessageBox.Show("Không tìm thấy địa điểm.");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("API calling failed: " + ex.Message);
                    return null;
                }
            }


        }

    }
}
