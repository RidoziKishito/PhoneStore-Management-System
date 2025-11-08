using GMap.NET.MapProviders;
using PhoneStore.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GMap.NET.Entity.OpenStreetMapGeocodeEntity;
using System.Xml.Linq;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace PhoneStore.Business
{
    public class ImportOrder
    {
        DBMain db = new DBMain();

        public DataSet GetAllImportOrder()
        {
            return db.ExecuteQuerryDataSet("EXEC sp_Get_All_Import_Order", CommandType.Text);
        }
        public bool AddImportOrder(string supplier_id, decimal total_value, DateTime import_date, DataTable rows, ref string error)
        {
            string sqlCmd = "EXEC sp_Insert_Import_Order_Full @supplier_id, @total_value, @import_date, @rows";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@supplier_id",supplier_id),
                new SqlParameter("@total_value", total_value),
                new SqlParameter("@import_date", import_date),
                new SqlParameter {
                    ParameterName = "@rows",
                    SqlDbType = SqlDbType.Structured,
                    TypeName = "dbo.ImportDetailType",
                    Value = rows
                }
            };
            return db.MyExecutedNoneQuerry(sqlCmd, CommandType.Text, parameters, ref error);
        }

            public bool DeleteImportOrder(string order_id, ref string error)
            {
                try
                {
                    string sqlCmd = "EXEC sp_Delete_Import_Order_Full @order_id";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                    new SqlParameter("@order_id", order_id),
                    };
                    return db.MyExecutedNoneQuerry(sqlCmd, CommandType.Text, parameters, ref error);
                }
                catch (SqlException ex)
                {
                    error = ex.Message;
                    return false;
                }
            }

        public DataSet GetImportOrderDetail(string order_id)
        {
            string sqlCmd = "EXEC sp_Get_Import_Order_Detail @order_id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@order_id", order_id),
            };
            return db.ExecuteQuerryDataSet(sqlCmd, CommandType.Text, parameters);
        }

        public DataSet GetImportOrderInMonth()
        {
            DateTime now = DateTime.Now;
            DateTime oneMonthAgo = now.AddMonths(-1);
            string sqlCmd = "EXEC sp_Get_Import_Orders_By_DateRange @oneMonthAgo, @now";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@now", now),
                new SqlParameter("@oneMonthAgo", oneMonthAgo)
            };

            return db.ExecuteQuerryDataSet(sqlCmd, CommandType.Text, parameters);
        }
    }
}
