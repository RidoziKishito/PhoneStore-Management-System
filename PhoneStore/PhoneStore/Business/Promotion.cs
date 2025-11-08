using PhoneStore.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.MapProviders;

namespace PhoneStore.Business
{
    public class Promotion
    {
        DBMain db = new DBMain();

        public DataTable GetAllPromotions()
        {
            string sql = "SELECT * FROM vw_promotion";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }
        public DataTable GetProductIDs()
        {
            string sql = "SELECT * FROM vw_product_summary";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }
        public bool AddPromotion(string condition, decimal percentage, DateTime start, DateTime end, ref string error)
        {
            string sql = "EXEC sp_Insert_Promotion @condition, @percentage, @start_date, @end_date";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@condition", condition),
                new SqlParameter("@percentage", percentage),
                new SqlParameter("@start_date", start),
                new SqlParameter("@end_date", end)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }

        public bool DeletePromotion(string id, ref string error)
        {
            string sql = "EXEC sp_Delete_Promotion @promotion_id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@promotion_id", id)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
        public bool CheckProductInPromotion(string productId)
        {
            string sql = "SELECT dbo.fn_IsProductInPromotion(@product_id)";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@product_id", productId)
            };

            object result = db.ExecuteQuerryDataSet(sql, CommandType.Text, parameters).Tables[0].Rows[0][0];
            return Convert.ToBoolean(result);
        }

        public DataTable GetSaleOrderPromotion(string promotion_id)
        {
            string sql = "EXEC sp_Get_SaleOrders_On_Promotion @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", promotion_id)
            };
            return db.ExecuteQuerryDataSet(sql, CommandType.Text, parameters).Tables[0];
        }


    }
}
