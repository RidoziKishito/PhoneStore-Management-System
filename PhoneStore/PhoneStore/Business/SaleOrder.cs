using PhoneStore.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Forms;
using PhoneStore.Forms;

namespace PhoneStore.Business
{
    public class SaleOrder
    {
        DBMain db = new DBMain();

        public DataTable GetAllOrders()
        {
            string sql = "SELECT * FROM vw_sale_order";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }

        // Lấy danh sách customer
        public DataTable GetCustomers()
        {
            string sql = "SELECT * FROM vw_customer_summary";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }

        // Lấy danh sách employee
        public DataTable GetEmployees()
        {
            string sql = "SELECT * FROM vw_employee_summary";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }

        // Lấy danh sách promotion
        public DataTable GetPromotions()
        {
            string sql = "SELECT * FROM vw_promotion_summary";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }

        public bool AddOrder(string customerId, string employeeId, string promotionId, string paymentMethod, DateTime saleDate, string status, decimal totalValue, DataTable rows, ref string error)
        {
            try
            {
                DialogResult result = MessageBox.Show("Confirm adding?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = "EXEC sp_Insert_Sale_Order_Full @customer_id, @employee_id, @promotion_id, @payment_method, @sale_date, @status, @total_value, @rows";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@customer_id", customerId),
                        new SqlParameter("@employee_id", employeeId),
                        new SqlParameter("@promotion_id", string.IsNullOrEmpty(promotionId) ? (object)DBNull.Value : promotionId),
                        new SqlParameter("@payment_method", paymentMethod),
                        new SqlParameter("@sale_date", saleDate),
                        new SqlParameter("@status", status),
                        new SqlParameter("@total_value", totalValue),
                        new SqlParameter {
                        ParameterName = "@rows",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.SaleDetailType",
                        Value = rows
                        }
                    };
                    return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }

        public bool DeleteOrder(string orderId, ref string error)
        {
            string sql = "EXEC sp_Delete_SaleOrder @order_id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@order_id", orderId)
            };

            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
        public DataTable GetSaleOrdersByDate(DateTime saleDate)
        {
            string sql = "EXEC sp_Get_SaleOrders_ByDate @sale_date";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@sale_date", saleDate)
            };
            return db.ExecuteQuerryDataSet(sql, CommandType.Text, parameters).Tables[0];
        }
        public DataTable GetSaleOrdersByStatus(string status)
        {
            string sql = "EXEC sp_Get_SaleOrders_ByStatus @status";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@status", status)
            };
            return db.ExecuteQuerryDataSet(sql, CommandType.Text, parameters).Tables[0];
        }
        public DataTable GetSaleOrdersByCustomer(string customerId)
        {
            string sql = "EXEC sp_Get_SaleOrders_ByCustomer @customer_id";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@customer_id", customerId)
            };
            return db.ExecuteQuerryDataSet(sql, CommandType.Text, parameters).Tables[0];
        }
        public decimal GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            string sql = "SELECT dbo.fn_TotalRevenue(@start_date, @end_date)";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@start_date", startDate),
            new SqlParameter("@end_date", endDate)
            };
            object result = db.ExecuteScalar(sql, CommandType.Text, parameters);
            return Convert.ToDecimal(result);
        }
        public decimal GetTotalDiscount(string orderId)
        {
            string sql = "SELECT dbo.fn_TotalDiscount(@order_id)";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@order_id", orderId)
            };
            object result = db.ExecuteScalar(sql, CommandType.Text, parameters);
            return Convert.ToDecimal(result);
        }
    }
}
