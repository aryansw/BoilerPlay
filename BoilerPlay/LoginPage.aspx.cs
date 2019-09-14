using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoilerPlay
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Login_Click(object sender, EventArgs e)
        {
            String inEmail = email.Value.ToString();
            String inPass = Password.Value.ToString();
            if (inEmail != null && inPass != null)
            {
                if (LoginCheck.Login(inEmail,inPass))
                {
                    bool x = LoginCheck.Login(inEmail, inPass);
                }
            }
            // TO DO : STORE COOKIE WITH ACCOUNT ID
        }
    }
}