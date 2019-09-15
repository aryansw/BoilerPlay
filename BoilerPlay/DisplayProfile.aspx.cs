using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoilerPlay
{
    public partial class DisplayProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String x = Request.QueryString["name"];
            DataTable data = Database.Query.ExecuteReturnCommand("Select ID from Accounts WHERE Name = '" + x + "';");
            String ID = data.Rows[0].ItemArray[0].ToString();
            Database.HelloWorldQueryMethods.Account acc = Database.HelloWorldQueryMethods.GetAccountFromID(ID);
            name.InnerText = acc.Name;
            email.Value = acc.Email;
            Year.Value = Database.HelloWorldQueryMethods.YearfromInt(acc.Year);
            description.Value = acc.Desc;
        }
        
    }
}