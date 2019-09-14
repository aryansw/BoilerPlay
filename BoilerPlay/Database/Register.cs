using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BoilerPlay.Database
{
    public static class Register
    {
        public static bool IsEmailUsed(String email)
        {
            DataTable output = Database.Query.ExecuteReturnCommand("select Email, Password from Accounts WHERE Email = '" + email + "';");
            try
            {
                String pass = output.Rows[0].ItemArray[1].ToString();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public static void RegisterAccount(String Name,String Desc,String Password,String Email, String PhoneNo, String Year)
        {
            if (!IsEmailUsed(Email))
            {
                String ID = Database.Query.ExecuteReturnCommand("select ID from Accounts order by ID asc");
                Database.Query.ExecuteNonReturnCommand("insert into Accounts VALUES ");
            }
        }
    }
}