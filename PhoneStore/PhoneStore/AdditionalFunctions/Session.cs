using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.AdditionalFunctions
{
    public static class Session
    {
        public static string CurrentUser { get; set; }
        public static string CurrentRole { get; set; }

        public static void Clear()
        {
            //Lấy cái CurrentUser thêm vào label kiểu Hello để biết user nào đang dùng
            CurrentUser = null;
            CurrentRole = null;
        }
    }
}
