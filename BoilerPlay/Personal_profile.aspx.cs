using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoilerPlay
{
    public partial class Personal_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cookies.WriteCookie("10001", this.Response);
            string x = Cookies.ReadCookie(this.Request, this.Response);
            Database.HelloWorldQueryMethods.Account acc = Database.HelloWorldQueryMethods.GetAccountFromCookie(this.Request, this.Response);
            Edit.Visible = true;
            SubmitChanges.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            Profile_Password1.Visible = false;
            Profile_Password.Visible = false;
            //Filling in textboxes
            ProfileName.Value = acc.Name;
            ProfileEmail.Value = acc.Email;
            Profile_Description.Value = acc.Desc;
            Profile_PhoneNumber.Value = acc.Phone;
            Profile_Year.Value = Database.HelloWorldQueryMethods.YearfromInt(acc.Year);

            //Making Readonly
            ProfileName.Attributes.Add("readonly", "readonly");
            ProfileEmail.Attributes.Add("readonly", "readonly");
            Profile_Description.Attributes.Add("readonly", "readonly");
            Profile_PhoneNumber.Attributes.Add("readonly", "readonly");
            Profile_Year.Attributes.Add("readonly", "readonly");
            Profile_Password.Attributes.Add("readonly", "readonly");
            Profile_Password1.Attributes.Add("readonly", "readonly");
        }

        protected void Edit_ServerClick(object sender, EventArgs e)
        {
            Edit.Visible = false;
            SubmitChanges.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            Profile_Password1.Visible = true;
            Profile_Password.Visible = true;
            ProfileName.Attributes.Remove("readonly");
            ProfileEmail.Attributes.Remove("readonly");
            Profile_Description.Attributes.Remove("readonly");
            Profile_PhoneNumber.Attributes.Remove("readonly");
            Profile_Year.Attributes.Remove("readonly");
            Profile_Password.Attributes.Remove("readonly");
            Profile_Password1.Attributes.Remove("readonly");
        }

        protected void SubmitChanges_ServerClick(object sender, EventArgs e)
        {
            Edit.Visible = true;
            SubmitChanges.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            Profile_Password1.Visible = false;
            Profile_Password.Visible = false;
        }
    }
}