﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoilerPlay
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Error_Flag.Visible = false;
        }
        protected void Register_ServerClick(object sender, EventArgs e)
        {
            if (Password.Value.ToString().Equals(Password1.Value.ToString())){
                String Year;
                if (form1.Checked)
                {
                    Year = "Freshman";
                }
                else if (form2.Checked)
                {
                    Year = "Sophomore";
                }
                else if (form3.Checked)
                {
                    Year = "Junior";
                }
                else if (form4.Checked)
                {
                    Year = "Senior";
                }
                else
                {
                    Year = "None";
                }
                
                Database.Register.RegisterAccount(Name.Value.ToString(), description.Value.ToString(), Password.Value.ToString(), email.Value.ToString(), phone.Value.ToString(), Year);
                Cookies.WriteCookie(Database.HelloWorldQueryMethods.GenerateNewProfileID().ToString(),this.Response);
                Response.Redirect("MainPage.aspx");
            }
            else
            {
                Error_Flag.Visible = true;
            }
        }
    }
}