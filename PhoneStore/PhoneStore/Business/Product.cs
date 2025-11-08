using PhoneStore.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Business
{
    internal class Product
    {
        DBMain db = new DBMain();
        public DataTable GetWarrantyIDs()
        {
            string sql = "exec GetWarrantyIDs";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }

        public DataTable GetProduct_Model_IDs()
        {
            string procName = "exec GetProductModelIDs";
            return db.ExecuteQuerryDataSet(procName, CommandType.Text).Tables[0];
        }


        public DataTable GetProducts()
        {
            string sql = "exec GetProducts";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }


        public bool AddProduct(string imei_sn, string product_id, string warranty_id, string status, DateTime? warranty_start, DateTime? warranty_end, ref string error)
        {
            string sql = "exec sp_Add_Product @imei_sn,@product_id,@warranty_id,@status,@warranty_start_date,@warranty_end_date";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@imei_sn", imei_sn),
                new SqlParameter("@product_id", product_id),
                new SqlParameter("@warranty_id", warranty_id),
                new SqlParameter("@status", status), // Fixed: Added the @ symbol to status parameter
                new SqlParameter("@warranty_start_date", DBNull.Value),
                new SqlParameter("@warranty_end_date", DBNull.Value)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
        public bool UpdateProduct(string imei_sn, string product_id, string warranty_id, string status, DateTime? warranty_start, DateTime? warranty_end, ref string error)
        {
            // Use the new sp_Update_Product stored procedure
            string sql = "exec sp_Update_Product @imei_sn,@product_id,@warranty_id,@status,@warranty_start_date,@warranty_end_date";
            
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@imei_sn", imei_sn),
                new SqlParameter("@product_id", product_id),
                new SqlParameter("@warranty_id", warranty_id),
                new SqlParameter("@status", status), 
                new SqlParameter("@warranty_start_date", warranty_start),
                new SqlParameter("@warranty_end_date", warranty_end)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
        public bool DeleteProduct(string imei_sn, ref string error) 
        {
            string sql = "exec sp_Delete_Product @imei_sn";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@imei_sn",imei_sn)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
        public int GetStockQuantity(string product_id)
        {
            try
            {
                string sql = "SELECT dbo.fn_Get_Stock_Quantity(@product_id)";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@product_id", product_id)
                };

                object result = db.ExecuteQuerryDataSet(sql, CommandType.Text, parameters).Tables[0].Rows[0][0];

                if (result == null || result == DBNull.Value)
                {
                    return 0;
                }

                return Convert.ToInt32(result);
            }
            catch (Exception)
            {
                return 0; // hoặc bạn có thể log lỗi nếu muốn
            }
        }

    }

}
