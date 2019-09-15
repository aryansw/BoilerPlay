using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BoilerPlay.Database
{
    public static class Register
    {
        public static string FixApostrophe(string inp)
        {
            inp = inp.Replace("'", "''");
            return inp;
        }
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
                int ID = Database.HelloWorldQueryMethods.GenerateNewProfileID();
                int yr;
                switch (Year)
                {
                    case "Freshman":
                        yr = 0;
                        break;
                    case "Sophomore":
                        yr = 1;
                        break;
                    case "Junior":
                        yr = 2;
                        break;
                    case "Senior":
                    default:
                        yr = 3;
                        break;
                }
                //Database.Query.ExecuteNonReturnCommand("insert into Accounts VALUES('" + ID + "','" + Name + "');
                Query.ExecuteNonReturnCommand(String.Format("INSERT INTO HelloWorld.Accounts " +
                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",
                    ID,
                    Name,
                    yr,
                    FixApostrophe(Desc),
                    Password,
                    Email,
                    PhoneNo));
            }
            else
            {
                throw new Exception("Email is already in use");
            }
        }
    }
}