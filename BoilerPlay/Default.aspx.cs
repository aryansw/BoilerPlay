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
            //To Run Login  
            bool z = BoilerPlay.LoginCheck.Login("wadhwani@purdue.edu","hellowordd");


            //var output = BoilerPlay.Database.Query.ExecuteReturnCommand("Select * FROM Accounts");
            var x = HelloWorldQueryMethods.GetAllInvolvementsForAccount("00001");


            var y = HelloWorldQueryMethods.GetAllPostsByLocation("Corec");
            
        }
    }
}