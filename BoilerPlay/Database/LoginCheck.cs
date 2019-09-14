using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BoilerPlay
{
    public static class LoginCheck
    {
        public static bool Login(String Email, String Password)
        {
            DataTable output = Database.Query.ExecuteReturnCommand("select Email, Password from Accounts WHERE Email = '" + Email + "';");
            String x = output.Rows[0].ItemArray[1].ToString();
            if (x!= null)
            {
                if (x.Equals(Password))
                {
                    return true;
                }
            }

            return false;
        }
    }
}