using PhoneStore.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Business
{
    public class SaleOrderDetail
    {
        DBMain db = new DBMain();

        public DataTable GetAllSaleOrderDetails()
        {
            string sql = "SELECT * FROM vw_sale_order_detail";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }
        public DataTable GetOrderIDs()
        {
            string sql = "SELECT * FROM vw_sale_order_summary";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }
        public DataTable GetIMEIs()
        {
            string sql = "SELECT * FROM vw_ImeiSNName_In_Stock";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }

        public bool AddSaleOrderDetail(string orderId, string imei, decimal discount, decimal price, ref string error)
        {
            string sql = "EXEC sp_Insert_SaleOrderDetail @order_id, @imei_sn, @discount, @selling_price";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@order_id", orderId),
                new SqlParameter("@imei_sn", imei),
                new SqlParameter("@discount", discount),
                new SqlParameter("@selling_price", price)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }

        public bool DeleteSaleOrderDetail(string orderId, string imei, ref string error)
        {
            string sql = "EXEC sp_Delete_SaleOrderDetail @order_id, @imei_sn";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@order_id", orderId),
                new SqlParameter("@imei_sn", imei)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
    }
}
