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
            String name = Request.QueryString["name"];
            DataTable data = Database.Query.ExecuteReturnCommand("Select ID from Accounts WHERE Name = '" + name + "';");
            String ID = data.Rows[0].ItemArray[0].ToString();
        }
        
    }
}