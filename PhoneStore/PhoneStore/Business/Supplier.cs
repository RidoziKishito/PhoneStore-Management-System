using GMap.NET.MapProviders;
using PhoneStore.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GMap.NET.Entity.OpenStreetMapGeocodeEntity;
using System.Xml.Linq;

namespace PhoneStore.Business
{
    public class Supplier
    {
        DBMain db = new DBMain();

        public bool AddSupplier(string name, string phoneNumber, string address, ref string error)
        {
            string sqlCmd = "EXEC sp_Insert_Supplier @name, @phoneNumber, @address";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@name", name),
                new SqlParameter("@phoneNumber", phoneNumber),
                new SqlParameter("@address", address),
            };
            return db.MyExecutedNoneQuerry(sqlCmd, CommandType.Text, parameters, ref error);
        }

        public bool UpdateSupplier(string id, string name, string phoneNumber, string address, ref string error)
        {
            string sqlCmd = "EXEC sp_Update_Supplier @id, @name, @phoneNumber, @address";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),
                new SqlParameter("@phoneNumber", phoneNumber),
                new SqlParameter("@address", address),
            };
            return db.MyExecutedNoneQuerry(sqlCmd, CommandType.Text, parameters, ref error);
        }

        public bool DeleteSupplier(string id, ref string error)
        {
            try
            {
                string sqlCmd = "EXEC sp_Delete_Supplier @id";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@id", id),
                };
                return db.MyExecutedNoneQuerry(sqlCmd, CommandType.Text, parameters, ref error);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public DataSet GetAllSupplier()
        {
            return db.ExecuteQuerryDataSet("EXEC sp_Get_All_Suppliers", CommandType.Text);
        }
        public DataSet GetAllSupplierName()
        {
            return db.ExecuteQuerryDataSet("EXEC sp_Get_All_Suppliers_Name", CommandType.Text);
        }

        public DataSet GetAddressByID(string id)
        {
            string sqlCmd = "EXEC sp_Get_Supplier_Address @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            return db.ExecuteQuerryDataSet(sqlCmd, CommandType.Text, parameters);
        }

        public DataSet GetProductOfSupplier(string id)
        {
            string sqlCmd = "EXEC sp_Get_Products_By_Supplier @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            return db.ExecuteQuerryDataSet(sqlCmd, CommandType.Text, parameters);
        }
    }
}
