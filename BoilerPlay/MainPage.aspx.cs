using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BoilerPlay
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // This is a Cookie DO NOT DELETE MONAL

            Cookies.ReadCookie(this.Request,this.Response);

            /* The Following code segment is to initalize
            
            var allValues = BoilerPlay.Database.Query.ExecuteReturnCommand("Select * FROM POSTS");

            String sportsBox = sportsComboBox.Text;
            String profeciencyBox = profeciencyComboBox.Text;
            String genderBox = genderComboxBox.Text;
            String dateBox = dateTimePicker.Value.ToString("yyyy-MM-dd");
            String timeBox1 = timeComboBox1.Text; //accept as hh:mm (smaller)
            String timeBox2 = timeComboBox2.Text; //accept as hh:mm (bigger value)

           

            DataTable dateFromDatabase = BoilerPlay.Database.Query.ExecuteReturnCommand("SELECT HelloWorld.Posts.DateTime FROM HelloWorld.Posts");
            string[] dates = new string[dateFromDatabase.Rows.Count];
            for (int x = 0; x < dateFromDatabase.Rows.Count; x++)
            {
                dates[x] = dateFromDatabase.Rows[x].ItemArray[0].ToString();
            }

            var tempValues = BoilerPlay.Database.Query.ExecuteReturnCommand("SELECT * FROM HelloWorld.Posts WHERE Gender ='" + genderBox + "' && Profeciency = '" + profeciencyBox + "' && Sports = '" + sportsBox + "';");


            for (int i = 0; i < (dates.Length); i++)
            {
                if (dates[i].Substring(0, 10).Equals(dateBox) && (Int32.Parse(timeBox2.Substring(0, 2))>= (Int32.Parse((dates[i].Substring(11, 13))))) && (Int32.Parse(timeBox1.Substring(0, 2)) <= (Int32.Parse((dates[i].Substring(11, 13))))) && (Int32.Parse(timeBox2.Substring(3, 5)) >= (Int32.Parse((dates[i].Substring(13, 15))))) && (Int32.Parse(timeBox1.Substring(3, 5)) <= (Int32.Parse((dates[i].Substring(13, 15))))))
                {
                    tempValues.Rows.RemoveAt(i);
                    i = i - 1;
                }
            }
            */
        }

    }
}