using PhoneStore.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Business
{
    public class Notification
    {
        DBMain db = new DBMain();
        public DataSet GetAllNotification()
        {
            return db.ExecuteQuerryDataSet("EXEC sp_Get_All_Notifcation_Message", CommandType.Text);
        }

        public bool IsExistNoti()
        {
            string sql = "SELECT dbo.fn_is_exist_notification()";
            return Convert.ToBoolean(db.ExecuteScalar(sql, CommandType.Text, null));
        }
    }
}
