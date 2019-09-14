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
    public static class Query
    {
        private static string connectionString = "server=104.154.172.96;user id=root;password=adminHelloWorld_1;persistsecurityinfo=True;database=HelloWorld";

        /// <summary>
        /// This executes a command that returns values. ie. SELECT
        /// </summary>
        /// <param name="commandString"></param>
        /// <returns></returns>
        public static DataTable ExecuteReturnCommand(string commandString)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(commandString, conn);
                da.Fill(dt);
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
        /// <summary>
        /// This executes a command that doesn't return any inputs ie. UPDATE, DELETE, INSERT
        /// </summary>
        /// <param name="commandString"></param>
        public static void ExecuteNonReturnCommand(string commandString)
        {
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = commandString;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}