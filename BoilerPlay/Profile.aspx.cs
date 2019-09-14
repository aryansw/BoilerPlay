using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoilerPlay
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string x = ReadCookie();
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string text = textBox.Value;
            MainBtn.InnerText = "HIOOO";
            WriteCookie("Hello There General Kenobi");
        }

        private string cookieName = "BoilerPlayCookie";
        void WriteCookie(string cookieValue)
        {
            //Create a new cookie, passing the name into the constructor
            HttpCookie cookie = new HttpCookie(cookieName);

            //Set the cookies value
            cookie.Value = cookieValue;

            //Set the cookie to expire in 1 minute
            DateTime dtNow = DateTime.Now;
            TimeSpan tsMinute = new TimeSpan(0, 10, 0, 0);
            cookie.Expires = dtNow + tsMinute;

            //Add the cookie
            Response.Cookies.Add(cookie);
        }
        string ReadCookie()
        {
            //Grab the cookie
            HttpCookie cookie = Request.Cookies[cookieName];

            //Check to make sure the cookie exists
            if (null == cookie)
            {
                Response.Write("Cookie not found. <br><hr>");
                return string.Empty;
            }
            else
            {
                //Write the cookie value
                String strCookieValue = cookie.Value.ToString();
                return strCookieValue;
                //Response.Write("The " + cookieName + " cookie contains: <b>"
                //                      + strCookieValue + "</b><br><hr>");
            }
        }
    }
}