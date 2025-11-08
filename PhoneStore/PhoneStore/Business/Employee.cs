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
    internal class Employee
    {
        private static DBMain db = new DBMain();

        public static DataTable GetAllEmployeePosition()
        {
            string strSQL = "SELECT * FROM vw_EmployeePositions";
            return db.ExecuteQuerryDataSet(strSQL, CommandType.Text).Tables[0];
        }
        public static DataTable GetEmployeeByPosition(string position)
        {
            string strSQL = "EXEC sp_Get_Employees_By_Position @position";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@position", position)
            };
            return db.ExecuteQuerryDataSet(strSQL, CommandType.Text, parameters).Tables[0];
        }
        public static bool DeleteEmployee(string employee_id, ref string error)
        {
            try
            {
                string strSQL = "EXEC sp_Delete_Employee @employee_id";
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@employee_id", employee_id) };
                return db.MyExecutedNoneQuerry(strSQL, CommandType.Text, parameters, ref error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
            public static bool InsertEmployee(string employee_name, string phone_number, string position, ref string error)
            {
                try
                {
                    string strSQL = "EXEC sp_Insert_Employee @employee_name, @phone_number, @position";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                    new SqlParameter("@employee_name", employee_name),
                    new SqlParameter("@phone_number", phone_number),
                    new SqlParameter("@position", position)
                    };
                    return db.MyExecutedNoneQuerry(strSQL, CommandType.Text, parameters, ref error);
                }
                catch (SqlException ex)
                {
                    error = ex.Message;
                    return false;
                }
            }
        public static bool UpdateEmployee(string employee_id, string employee_name, string phone_number, string position, ref string error)
        {
            try
            {
                string strSQL = "EXEC sp_Update_Employee @employee_id, @employee_name, @phone_number, @position";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@employee_id", employee_id),
                new SqlParameter("@employee_name", employee_name),
                new SqlParameter("@phone_number", phone_number),
                new SqlParameter("@position", position)
                };
                return db.MyExecutedNoneQuerry(strSQL, CommandType.Text, parameters, ref error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
