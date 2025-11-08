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
    internal class ProductModel
    {
        DBMain db = new DBMain();

        public DataTable GetProduct_Model_IDs()
        {
            string procName = "GetProductModelIDs";
            return db.ExecuteQuerryDataSet(procName, CommandType.StoredProcedure).Tables[0];
        }

        public DataTable GetProductsModel()
        {
            string sql = "exec GetProductsModel";
            return db.ExecuteQuerryDataSet(sql, CommandType.Text).Tables[0];
        }

        public bool AddProductModel(string product_name, string brand, int quantity, decimal listed_price, ref string error)
        {
            string sql = "exec sp_Add_Product_Model @product_name,@brand,@quantity,@listed_price";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@product_name", product_name),
                new SqlParameter("@brand",brand),
                new SqlParameter("@quantity",quantity),
                new SqlParameter("@listed_price",listed_price)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
        public bool UpdateProductModel(string product_id, string product_name, string brand, int quantity, decimal listed_price, ref string error)
        {
            string sql = "exec sp_Update_Product_Model @product_id,@product_name,@brand,@quantity,@listed_price";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@product_id", product_id),
                new SqlParameter("@product_name",product_name),
                new SqlParameter("@brand",brand),
                new SqlParameter("@quantity",quantity),
                new SqlParameter("@listed_price",listed_price)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
        public bool DeleteProductModel(string product_id, ref string error)
        {
            string sql = "exec sp_Delete_Product_Model @product_id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@product_id",product_id)
            };
            return db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
        }
        public decimal GetListedPrice(string product_id)
        {
            try
            {
                string sql = "select dbo.fn_Get_Listed_Price(@product_id)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@product_id", product_id)
                };

                object result = db.ExecuteQuerryDataSet(sql, CommandType.Text, parameters).Tables[0].Rows[0][0];

                // Check for DBNull or null
                if (result == null || result == DBNull.Value)
                {
                    return 0; // Return 0 if no price found
                }

                // Convert the result to decimal (not boolean)
                return Convert.ToDecimal(result);
            }
            catch (Exception)
            {
                // Handle exceptions, return 0 for simplicity
                return 0;
            }
        }

        public bool InsertPicture(string product_id, string picture_name, ref string error)
        {
            try
            {
                string sql = "EXEC sp_Insert_Product_Model_Picture @product_id, @picture_name";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@product_id", product_id),
                    new SqlParameter("@picture_name", picture_name)
                };

                db.MyExecutedNoneQuerry(sql, CommandType.Text, parameters, ref error);
            }
            catch (Exception)
            {
                // Handle exceptions, return 0 for simplicity
                return false;
            }
            return true;
        }
    }
}
