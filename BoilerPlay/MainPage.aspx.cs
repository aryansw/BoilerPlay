using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BoilerPlay
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* The Following code segment is to initalize*/

            var x = BoilerPlay.Database.Query.ExecuteReturnCommand("Select * FROM POSTS");

            //String sportsBox = sportsComboBox.Text;
            //String profeciencyBox = profeciencyComboBox.Text;
            //String genderBox = genderComboxBox.Text;
            //String dateBox = dateTimePicker.Value.ToString("yyyy-MM-dd");
            //String timeBox = timeComboBox.Text;

            /*if(sportsBox.Equals("All"))
            {
                
            }*/
            //for (int i = 0; i <)

            //x.Rows[0].ItemArray[0];
        }

    }
}