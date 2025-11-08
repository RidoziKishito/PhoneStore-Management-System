using PhoneStore.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Business
{
    public class Temporary
    {
        DBMain db = new DBMain();

        public DataSet GetAllProductName()
        {
            return db.ExecuteQuerryDataSet("EXEC sp_Get_All_Product_Name", CommandType.Text);
        }

    }
}
