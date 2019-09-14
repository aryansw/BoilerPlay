using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BoilerPlay.Database;

namespace BoilerPlay
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //var output = BoilerPlay.Database.Query.ExecuteReturnCommand("Select * FROM Accounts");
            //var x = HelloWorldQueryMethods.GetAllInvolvementsForAccount("00001");


            //var y = HelloWorldQueryMethods.GetAllPostsByLocation("Corec");
            /*
            HelloWorldQueryMethods.Posts post = new HelloWorldQueryMethods.Posts
            {
                Location = "corec",
                Gender = DatabaseOptions.Posts_Gender.Male,
                NumberNeeded = 1,
                Title = "Pool",
                Proficiency = DatabaseOptions.Posts_Proficiency.Skilled,
                Desc = "Need 1 person to play pool in the corec",
                DateTime = DateTime.Now,
                Posts_Name = "Host Name"
            };
            HelloWorldQueryMethods.CreatePostInDataBase(post);
            */
        }
    }
}