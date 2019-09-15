using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using BoilerPlay.Database;

namespace BoilerPlay
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // This is a Cookie DO NOT DELETE MONAL

            Cookies.ReadCookie(this.Request,this.Response);

            HelloWorldQueryMethods.Posts[] allPosts = HelloWorldQueryMethods.GetAllPosts();

            int count = allPosts.Length;
            if (count > 10)
                count = 10;
            
            for(int x = 0; x < 10; x++)
            {
                //((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("card" + x)).Visible = false;
            }
            for (int x = 0; x < count; x++)
            {
                //((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("card" + x)).Visible = true;

                string peopleText = String.Format("People Commited {0}/{1}", allPosts[x].NumberNeeded, HelloWorldQueryMethods.GetNumberOfPeopleInEvent(allPosts[x].PostID));
                ((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("DatePrint" + x)).InnerText = allPosts[x].DateTime.ToString("dd/MM/yyyy hh:mm:ss");
                ((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("Location" + x)).InnerText = allPosts[x].Location;
                ((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("Proficiency" + x)).InnerText = allPosts[x].Proficiency;
                ((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("People" + x)).InnerText = peopleText;
                ((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("Description" + x)).InnerText = allPosts[x].Desc;
            }

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