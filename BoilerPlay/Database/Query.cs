using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BoilerPlay.Database
{
    public class Query
    {
        private string connectionString = "server=104.154.172.96;user id=root;password=adminHelloWorld_1;persistsecurityinfo=True;database=HelloWorld";
        private DataTable ExecuteReturnCommand(string commandString)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(commandString, conn);
                da.Fill(dt);

                //dg.DataSource = dt.Tables[0];

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return dt;
        }
    }
}