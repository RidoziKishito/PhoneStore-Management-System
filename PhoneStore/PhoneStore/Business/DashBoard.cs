using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStore.Database;
using System.Data.SqlClient;

namespace PhoneStore.Business
{
    public class DashBoard
    {
        public static DBMain db = new DBMain();
        public static DataTable GetTop5SuppliersByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                string strSQL = "EXEC sp_Top5SuppliersByDateRange @StartDate, @EndDate";
                // Create parameters for the stored procedure
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@StartDate", startDate),
                    new SqlParameter("@EndDate", endDate)
                };

                // Execute the stored procedure and return the first table from the result
                DataTable dt = db.ExecuteQuerryDataSet(strSQL, CommandType.Text, parameters).Tables[0];

                // Return an empty DataTable if the result is empty
                return dt;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error in GetTop5SuppliersByDateRange: {ex.Message}");
                return new DataTable();
            }
        }

        // Helper method to get data from the beginning of the current year to the present date
        public static DataTable GetTop5SuppliersForCurrentYear()
        {
            // Calculate the start and end dates for the current year
            DateTime currentDate = DateTime.Now;
            DateTime startDate = new DateTime(currentDate.Year, 1, 1); // January 1st of the current year
            DateTime endDate = currentDate; // Today's date

            // Get data for the current year to date
            return GetTop5SuppliersByDateRange(startDate, endDate);
        }
        public static DataTable GetTop10BestSellingProducts(DateTime startDate, DateTime endDate)
        {
            try
            {
                string strSQL = "EXEC sp_Top10BestSellingProducts @StartDate, @EndDate";
                // Create parameters for the stored procedure
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@StartDate", startDate),
                    new SqlParameter("@EndDate", endDate)
                };

                // Execute the stored procedure and return the first table from the result
                DataTable dt = db.ExecuteQuerryDataSet(strSQL, CommandType.Text, parameters).Tables[0];

                // Return the result
                return dt;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error in GetTop10BestSellingProducts: {ex.Message}");
                return new DataTable();
            }
        }
        public static DataTable GetTop10BestSellingProductsForCurrentYear()
        {
            // Calculate the start and end dates for the current year
            DateTime currentDate = DateTime.Now;
            DateTime startDate = new DateTime(currentDate.Year, 1, 1); // January 1st of the current year
            DateTime endDate = currentDate; // Today's date

            // Get data for the current year to date
            return GetTop10BestSellingProducts(startDate, endDate);
        }
        public static DataTable GetTopEmployeesByRevenue(DateTime startDate, DateTime endDate)
        {
            try
            {
                string strSQL = "EXEC sp_TopEmployeesByRevenue @StartDate, @EndDate";
                // Create parameters for the stored procedure
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@StartDate", startDate),
            new SqlParameter("@EndDate", endDate)
                };

                // Execute the stored procedure and return the first table from the result
                DataTable dt = db.ExecuteQuerryDataSet(strSQL, CommandType.Text, parameters).Tables[0];

                // Return the result
                return dt;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error in GetTopEmployeesByRevenue: {ex.Message}");
                return new DataTable();
            }
        }

        public static DataTable GetTopEmployeesByRevenueForCurrentYear()
        {
            // Calculate the start and end dates for the current year
            DateTime currentDate = DateTime.Now;
            DateTime startDate = new DateTime(currentDate.Year, 1, 1); // January 1st of the current year
            DateTime endDate = currentDate; // Today's date

            // Get data for the current year to date
            return GetTopEmployeesByRevenue(startDate, endDate);
        }
        public static DataTable GetTop10Customers()
        {
            try
            {
                string strSQL = "SELECT * FROM vw_Top10Customers";
                return db.ExecuteQuerryDataSet(strSQL, CommandType.Text).Tables[0];
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error in GetTop10Customers: {ex.Message}");
                return new DataTable();
            }
        }
    }
}
