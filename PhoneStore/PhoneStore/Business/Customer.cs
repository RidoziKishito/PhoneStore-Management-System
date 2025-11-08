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
    internal class Customer
    {
        private static DBMain db = new DBMain();
        public static bool InsertCustomer(string customer_name, string phone_number, string email, ref string error)
        {
            try
            {
                string strSQL = "EXEC sp_Insert_Customer @customer_name, @phone_number, @email";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@customer_name", customer_name),
                    new SqlParameter("@phone_number", phone_number),
                    new SqlParameter("@email", email)
                };
                return db.MyExecutedNoneQuerry(strSQL, CommandType.Text, parameters, ref error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public static bool UpdateCustomer(string customer_id, string customer_name, string phone_number, string email, ref string error)
        {
            try
            {
                string strSQL = "EXEC sp_Update_Customer @customer_id, @customer_name, @phone_number, @email";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@customer_id", customer_id),
                    new SqlParameter("@customer_name", customer_name),
                    new SqlParameter("@phone_number", phone_number),
                    new SqlParameter("@email", email)
                };
                return db.MyExecutedNoneQuerry(strSQL, CommandType.Text, parameters, ref error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public static bool DeleteCustomer(string customer_id, ref string error)
        {
            try
            {
                string strSQL = "EXEC sp_Delete_Customer @customer_id";
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@customer_id", customer_id) };
                return db.MyExecutedNoneQuerry(strSQL, CommandType.Text, parameters, ref error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public static DataTable GetAllCustomer()
        {
            string strSQL = "SELECT * FROM customer";
            return db.ExecuteQuerryDataSet(strSQL, CommandType.Text).Tables[0];
        }
        public static DataTable GetAllCustomerInfo()
        {
            string strSQL = "SELECT * FROM vw_customers_info";
            return db.ExecuteQuerryDataSet(strSQL, CommandType.Text).Tables[0];
        }
        public static DataTable GetCustomerByPhoneNumberForEmployee(string phone_number)
        {
            string strSQL = "SELECT * FROM vw_customers_info WHERE PhoneNumber LIKE @phone_number + '%'";
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@phone_number", phone_number) };
            return db.ExecuteQuerryDataSet(strSQL, CommandType.Text, parameters).Tables[0];
        }
        public static DataTable GetCustomerByPhoneNumber(string phone_number)
        {
            string strSQL = "EXEC sp_Get_Customer_By_Phone @phone_number";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@phone_number", phone_number)
            };
            return db.ExecuteQuerryDataSet(strSQL, CommandType.Text, parameters).Tables[0];
        }
    }
}
