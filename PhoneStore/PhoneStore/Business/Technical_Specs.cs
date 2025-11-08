using PhoneStore.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using GMap.NET.MapProviders;
namespace PhoneStore.Business
{
    internal class Technical_Specs
    {
        DBMain db = new DBMain();
        public DataTable GetProduct_Model_IDs()
        {
            string sql = "exec GetProductModelIDs";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }


        public DataTable getTechnicalSpecs()
        {
            string sql = "exec GetTechSpecs";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }

        public bool AddTechSpecs(string tech_name,string product_id, string detail,ref string error)
        {
            string sql = "exec sp_Add_Technical_Specification @tech_name,@product_id, @detail";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tech_name",tech_name), 
                new SqlParameter("@product_id",product_id),
                new SqlParameter("@detail",detail)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
        public bool DeleteTechSpecs(string tech_name, string product_id,ref string error)
        {
            string sql = "exec sp_Delete_Technical_Specification @tech_name,@product_id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tech_name",tech_name),
                new SqlParameter("@product_id",product_id)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
        public bool UpdateTechSpecs(string tech_name, string product_id, string detail, ref string error)
        {
            string sql = " exec sp_Update_Technical_Specification @tech_name,@product_id,@detail";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tech_name",tech_name),
                new SqlParameter("@product_id",product_id),
                new SqlParameter("@detail",detail)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
    }
}
