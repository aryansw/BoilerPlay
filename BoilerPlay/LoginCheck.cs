using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BoilerPlay
{
    public class LoginCheck
    {
        public Boolean login(String , String Password);
        BoilerPlay.Database.Query query = new Database.Query();
        DataTable output = query.ExecuteReturnCommand("Select * from Accounts");
        String x = output.Rows[0].ItemArray[1].ToString();
        Console.WriteLine(x);
    }
}