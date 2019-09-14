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
                return false;
            }
            catch(Exception e)
            {
                return true;
            }
        }
        public static void RegisterAccount(String Name,int Desc,String Password,String Email, String PhoneNo)
        {

        }
    }
}