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

            int timeBox2totalTime = ((Int32.Parse(timeBox2.Substring(0, 2))) * 60) + ((Int32.Parse(timeBox2.Substring(3, 5))));
            int timeBox1totalTime = ((Int32.Parse(timeBox1.Substring(0, 2))) * 60) + ((Int32.Parse(timeBox1.Substring(3, 5))));
            int timeDifference = timeBox2totalTime - timeBox1totalTime;

            int hh = (timeDifference / 60);
            int mm = (timeDifference % 60);

            String timebox = hh.ToString() + ":" + mm.ToString();

            DataTable dateFromDatabase = BoilerPlay.Database.Query.ExecuteReturnCommand("SELECT HelloWorld.Posts.DateTime FROM HelloWorld.Posts");
            string[] dates = new string[dateFromDatabase.Rows.Count];
            for (int x = 0; x < dateFromDatabase.Rows.Count; x++)
            {
                dates[x] = dateFromDatabase.Rows[x].ItemArray[0].ToString();
            }

            var tempValues = BoilerPlay.Database.Query.ExecuteReturnCommand("SELECT * FROM HelloWorld.Posts WHERE Gender ='" + genderBox + "' && Profeciency = '" + profeciencyBox + "' && Sports = '" + sportsBox + "';");


            for (int i = 0; i < (dates.Length); i++)
            {
                if (dates[i].Substring(0, 10).Equals(dateBox) && (dates[i].Substring(11, 15).Equals(timeBox)))
                {
                    tempValues.Rows.RemoveAt(i);
                    i = i - 1;
                }
            }
            */



            //for (int i = 0; i <)

            //x.Rows[0].ItemArray[0];
        }

    }
}