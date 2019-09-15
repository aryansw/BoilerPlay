using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoilerPlay
{
    public partial class Create_Event : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string cookie = Cookies.ReadCookie(this.Request, this.Response);
                if(String.IsNullOrWhiteSpace(cookie))
                {
                    Response.Redirect("LoginPage.aspx");
                }
            }
            catch
            {
                Response.Redirect("LoginPage.aspx");
            }
            failedMessage.Visible = false;
            createEventBtn.Enabled = false;

            foreach(var sport in Database.DatabaseOptions.Posts_Sports.SportsCombinations)
                SportName.Items.Add(sport);
        }
        protected void CreateEve_ServerClick(object sender, EventArgs e)
        {
            String sportsBox = SportName.Value;
            String profeciencyBox = proficiency.Value;
            String genderBox = Gender.Value;
            int reqPeopleBox = Int32.Parse(ReqPeople.Value);

            if (reqPeopleBox <= 0)
            {
                failedMessage.Visible = true;
                failedMessage.InnerText = "The Number of people MUST be greater than 0";
            }
            else
            {
                reqPeopleBox++;//this is to accomodate the host as one participant

                String locationBox = Location.Value;
                String sportDescriptionBox = SportDescription.Value;
                String dateBox = Calendar.SelectedDate.ToString("yyyy-MM-dd");
                String timeBox = appt.Value;
                String dateTimeBox = dateBox + " " + timeBox + ":00";
                Database.HelloWorldQueryMethods.Posts posts = new Database.HelloWorldQueryMethods.Posts();
                posts.Title = sportsBox;
                Database.HelloWorldQueryMethods.Account acc = new Database.HelloWorldQueryMethods.Account();
                //Cookies.WriteCookie("10001", this.Response); // To be removed when sites are connected
                acc = Database.HelloWorldQueryMethods.GetAccountFromCookie(this.Request, this.Response);
                posts.Posts_Name = acc.Name;
                posts.Gender = genderBox;
                posts.Desc = sportDescriptionBox;
                posts.Location = locationBox;
                posts.NumberNeeded = reqPeopleBox;
                posts.Proficiency = profeciencyBox;
                posts.DateTime = DateTime.Parse(dateTimeBox);



                try
                {
                    string postID = Database.HelloWorldQueryMethods.CreatePostInDataBase(posts);
                    Database.HelloWorldQueryMethods.Involvement involvement = new Database.HelloWorldQueryMethods.Involvement();
                    involvement.AccountsID = acc.ID;
                    involvement.Posts_PostID = postID;
                    involvement.IsHost = true;
                    Database.HelloWorldQueryMethods.InsertInvolvement(involvement);
                    Response.Redirect("MainPage.aspx");
                }
                catch
                {

                }
            }
        }

        protected void createEventBtn_Click(object sender, EventArgs e)
        {

        }

        protected void allEventsBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }

        protected void myEventBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx?myEvents=true");
        }

        protected void profileBtn_Click(object sender, EventArgs e)
        {

        }
    }
}