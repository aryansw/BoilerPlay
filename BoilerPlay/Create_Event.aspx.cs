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
            
        }
        protected void CreateEve_ServerClick(object sender, EventArgs e)
        {
            String sportsBox = SportName.Value;
            String profeciencyBox = SportName.Value;
            String genderBox = Gender.Value;
            int reqPeopleBox = Int32.Parse(ReqPeople.Value);
            String locationBox = Location.Value;
            String sportDescriptionBox = SportDescription.Value;
            String dateBox = Calendar.SelectedDate.ToString("yyyy-MM-dd");
            String timeBox = appt.Value;
            String dateTimeBox = dateBox +" " + timeBox+":00";
            Database.HelloWorldQueryMethods.Posts posts = new Database.HelloWorldQueryMethods.Posts();
            posts.Title = sportsBox;
            Database.HelloWorldQueryMethods.Account acc = new Database.HelloWorldQueryMethods.Account();
            Cookies.WriteCookie("10001", this.Response); // To be removed when sites are connected
            acc = Database.HelloWorldQueryMethods.GetAccountFromCookie(this.Request,this.Response);
            posts.Posts_Name = acc.Name;
            posts.Gender = genderBox;
            posts.Desc = sportDescriptionBox;
            posts.Location = locationBox;
            posts.NumberNeeded = reqPeopleBox;
            posts.Proficiency = profeciencyBox;


         
            Database.HelloWorldQueryMethods.CreatePostInDataBase(posts);
        }
    }
}