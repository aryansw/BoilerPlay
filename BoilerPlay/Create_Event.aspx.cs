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
            String reqPeopleBox = ReqPeople.Value;
            String locationBox = Location.Value;
            String sportDescriptionBox = SportDescription.Value;
            String dateBox = Calendar.SelectedDate.ToString("yyyy-MM-dd");
            String timeBox = appt.Value;

        //    Database.HelloWorldQueryMethods.Posts();

            //String timeBox1 = timeComboBox1.Text; //accept as hh:mm (smaller)
            // String timeBox2 = timeComboBox2.Text; //accept as hh:mm (bigger value)
            // Database.HelloWorldQueryMethods.CreatePostInDataBase
        }
    }
}