using GMap.NET.MapProviders;
using PhoneStore.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStore.Business
{
    internal class Warranty
    {
        DBMain db = new DBMain();
        public DataTable GetWarrantyIDs()
        {
            string sql = "exec GetWarrantyIDs";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }

        public DataTable GetWarranty()
        {
            string sql = "exec GetWarranty";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];

        }


        public bool AddWarranty(string detail, string warranty_name, int duration,ref string error)
        {
            string sql = "exec sp_Add_Warranty @detail, @warranty_name,@duration";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@detail",detail),
                new SqlParameter("@warranty_name",warranty_name),
                new SqlParameter("@duration",duration)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);

        }
        public bool DeleteWarranty(string warranty_id,ref string error)
        {
            string sql = "exec sp_Delete_Warranty @warranty_id";
            
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@warranty_id", warranty_id)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
    }
}
