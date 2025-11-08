using PhoneStore.AdditionalFunctions;
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
    public class Login
    {
        static DBMain db = new DBMain();
        public static bool VerifyLogin(string username, string password, out string error)
        {
            error = string.Empty;

            try
            {
                // Parameters for VerifyLogin stored procedure
                SqlParameter[] loginParams = new SqlParameter[]
                {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password),
                    new SqlParameter("@IsValid", SqlDbType.Bit) { Direction = ParameterDirection.Output }
                };

                // Execute VerifyLogin stored procedure
                db.MyExecutedNoneQuerry("VerifyLogin", CommandType.StoredProcedure, loginParams, ref error);

                bool isValid = (bool)loginParams[2].Value;

                if (isValid)
                {
                    // Parameters for GetUserInfo stored procedure
                    SqlParameter[] userInfoParams = new SqlParameter[]
                    {
                        new SqlParameter("@Username", username)
                    };

                    // Execute GetUserInfo stored procedure and retrieve user role
                    DataSet ds = db.ExecuteQuerryDataSet("GetUserInfo", CommandType.StoredProcedure, userInfoParams);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];
                        Session.CurrentUser = row["Username"].ToString().Trim();
                        Session.CurrentRole = row["RoleName"].ToString().Trim();
                    }
                }

                return isValid;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
