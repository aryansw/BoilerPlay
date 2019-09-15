using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using BoilerPlay.Database;
using System.Web.Services;
using System.Threading.Tasks;

namespace BoilerPlay
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(Cookies.ReadCookie(this.Request, this.Response)))
            {
                Response.Redirect("LoginPage.aspx");
            }
            // This is a Cookie DO NOT DELETE MONAL+
            successMessage.Visible = false;
            allEventsBtn.Enabled = false;

            //Cookies.ReadCookie(this.Request,this.Response);

            if (!IsPostBack)
            {
                SetCards();
            }


            /* The Following code segment is to initalize
            
            var allValues = BoilerPlay.Database.Query.ExecuteReturnCommand("Select * FROM POSTS");

            String sportsBox = sportsComboBox.Text;
            String profeciencyBox = profeciencyComboBox.Text;
            String genderBox = genderComboxBox.Text;
            String dateBox = dateTimePicker.Value.ToString("yyyy-MM-dd");
            String timeBox1 = timeComboBox1.Text; //accept as hh:mm (smaller)
            String timeBox2 = timeComboBox2.Text; //accept as hh:mm (bigger value)

           

            DataTable dateFromDatabase = BoilerPlay.Database.Query.ExecuteReturnCommand("SELECT HelloWorld.Posts.DateTime FROM HelloWorld.Posts");
            string[] dates = new string[dateFromDatabase.Rows.Count];
            for (int x = 0; x < dateFromDatabase.Rows.Count; x++)
            {
                dates[x] = dateFromDatabase.Rows[x].ItemArray[0].ToString();
            }

            var tempValues = BoilerPlay.Database.Query.ExecuteReturnCommand("SELECT * FROM HelloWorld.Posts WHERE Gender ='" + genderBox + "' && Profeciency = '" + profeciencyBox + "' && Sports = '" + sportsBox + "';");


            for (int i = 0; i < (dates.Length); i++)
            {
                if (dates[i].Substring(0, 10).Equals(dateBox) && (Int32.Parse(timeBox2.Substring(0, 2))>= (Int32.Parse((dates[i].Substring(11, 13))))) && (Int32.Parse(timeBox1.Substring(0, 2)) <= (Int32.Parse((dates[i].Substring(11, 13))))) && (Int32.Parse(timeBox2.Substring(3, 5)) >= (Int32.Parse((dates[i].Substring(13, 15))))) && (Int32.Parse(timeBox1.Substring(3, 5)) <= (Int32.Parse((dates[i].Substring(13, 15))))))
                {
                    tempValues.Rows.RemoveAt(i);
                    i = i - 1;
                }
            }
            */
        }
        private void SetCards(int index = -1)
        {
            if(index == -1)
                MainPageGlobals.Posts = HelloWorldQueryMethods.GetAllPosts();

            string AccountID = Cookies.ReadCookie(this.Request, this.Response);
            string[] involvementsForAccount = HelloWorldQueryMethods.GetAllInvolvementsForAccount(AccountID);

            int count = MainPageGlobals.Posts.Length;
            if (count > 10)
                count = 10;

            for (int x = 0; x < 10; x++)
            {
                ((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("card" + x)).Visible = false;
            }
            for (int x = 0; x < count; x++)
            {
                ((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("card" + x)).Visible = true;

                string peopleText;
                int totalNumberOfPeopleNeeded = MainPageGlobals.Posts[x].NumberNeeded;
                int currentNumber = HelloWorldQueryMethods.GetNumberOfPeopleInEvent(MainPageGlobals.Posts[x].PostID);
                if (index == x)
                {
                    peopleText = String.Format("People Commited: {0}/{1}", currentNumber + 1, totalNumberOfPeopleNeeded);
                    HelloWorldQueryMethods.Involvement involvement = new HelloWorldQueryMethods.Involvement
                    {
                        AccountsID = AccountID,
                        IsHost = false,
                        Posts_PostID = MainPageGlobals.Posts[x].PostID
                    };
                    HelloWorldQueryMethods.InsertInvolvement(involvement);
                    ((System.Web.UI.HtmlControls.HtmlButton)this.FindControl("button" + x)).Disabled = true;
                    ((System.Web.UI.HtmlControls.HtmlButton)this.FindControl("button" + x)).InnerText = "Currently Joined";
                }
                else
                    peopleText = String.Format("People Commited: {0}/{1}", currentNumber, totalNumberOfPeopleNeeded);

                ((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("DatePrint" + x)).InnerText = MainPageGlobals.Posts[x].DateTime.ToString("dd/MM/yyyy hh:mm:ss");
                ((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("Location" + x)).InnerText = MainPageGlobals.Posts[x].Location;
                ((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("Proficiency" + x)).InnerText = MainPageGlobals.Posts[x].Proficiency;
                ((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("People" + x)).InnerText = peopleText;
                ((System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("Description" + x)).InnerText = MainPageGlobals.Posts[x].Desc;

                //UpdateMainPageGlobals
                if (involvementsForAccount.Contains(MainPageGlobals.Posts[x].PostID))
                {
                    ((System.Web.UI.HtmlControls.HtmlButton)this.FindControl("button" + x)).Disabled = true;
                    ((System.Web.UI.HtmlControls.HtmlButton)this.FindControl("button" + x)).InnerText = "Currently Joined";
                }
                else if(currentNumber >= totalNumberOfPeopleNeeded)
                {
                    ((System.Web.UI.HtmlControls.HtmlButton)this.FindControl("button" + x)).Disabled = true;
                    ((System.Web.UI.HtmlControls.HtmlButton)this.FindControl("button" + x)).InnerText = "Event Full";
                }
            }
        }
        private void SetSuccessMessage()
        {
            //successMessage.Visible = true;
            //successPrint.InnerText = "You have been successfully added to the event";
        }
        protected void button0_ServerClick(object sender, EventArgs e)
        {
            string PostID = MainPageGlobals.Posts[(MainPageGlobals.CurrentPage * 10) + 0].PostID;
            //HelloWorldQueryMethods.IncrementNumberOfAttendees(PostID);
            SetCards(0);
            SetSuccessMessage();
        }
        protected void button1_ServerClick(object sender, EventArgs e)
        {
            string PostID = MainPageGlobals.Posts[(MainPageGlobals.CurrentPage * 10) + 1].PostID;
            //HelloWorldQueryMethods.IncrementNumberOfAttendees(PostID);
            SetCards(1);
            SetSuccessMessage();
        }

        protected void button2_ServerClick(object sender, EventArgs e)
        {
            string PostID = MainPageGlobals.Posts[(MainPageGlobals.CurrentPage * 10) + 2].PostID;
            //HelloWorldQueryMethods.IncrementNumberOfAttendees(PostID);
            SetCards(2);
            SetSuccessMessage();
        }

        protected void button3_ServerClick(object sender, EventArgs e)
        {
            string PostID = MainPageGlobals.Posts[(MainPageGlobals.CurrentPage * 10) + 3].PostID;
            //HelloWorldQueryMethods.IncrementNumberOfAttendees(PostID);
            SetCards(3);
            SetSuccessMessage();
        }

        protected void button4_ServerClick(object sender, EventArgs e)
        {
            string PostID = MainPageGlobals.Posts[(MainPageGlobals.CurrentPage * 10) + 4].PostID;
            //HelloWorldQueryMethods.IncrementNumberOfAttendees(PostID);
            SetCards(4);
            SetSuccessMessage();
        }

        protected void button5_ServerClick(object sender, EventArgs e)
        {
            string PostID = MainPageGlobals.Posts[(MainPageGlobals.CurrentPage * 10) + 5].PostID;
            //HelloWorldQueryMethods.IncrementNumberOfAttendees(PostID);
            SetCards(5);
            SetSuccessMessage();
        }

        protected void button6_ServerClick(object sender, EventArgs e)
        {
            string PostID = MainPageGlobals.Posts[(MainPageGlobals.CurrentPage * 10) + 6].PostID;
            //HelloWorldQueryMethods.IncrementNumberOfAttendees(PostID);
            SetCards(6);
            SetSuccessMessage();
        }

        protected void button7_ServerClick(object sender, EventArgs e)
        {
            string PostID = MainPageGlobals.Posts[(MainPageGlobals.CurrentPage * 10) + 7].PostID;
            //HelloWorldQueryMethods.IncrementNumberOfAttendees(PostID);
            SetCards(7);
            SetSuccessMessage();
        }

        protected void button8_ServerClick(object sender, EventArgs e)
        {
            string PostID = MainPageGlobals.Posts[(MainPageGlobals.CurrentPage * 10) + 8].PostID;
            //HelloWorldQueryMethods.IncrementNumberOfAttendees(PostID);
            SetCards(8);
            SetSuccessMessage();
        }

        protected void button9_ServerClick(object sender, EventArgs e)
        {
            string PostID = MainPageGlobals.Posts[(MainPageGlobals.CurrentPage * 10) + 9].PostID;
            //HelloWorldQueryMethods.IncrementNumberOfAttendees(PostID);
            SetCards(9);
            SetSuccessMessage();
        }

        protected void createEventBtn_Click(object sender, EventArgs e)
        {

        }
        protected void myEventBtn_Click(object sender, EventArgs e)
        {
            allEventsBtn.Enabled = true;
            myEventBtn.Enabled = false;

            string accountID = Cookies.ReadCookie(this.Request, this.Response);
            var involvements = HelloWorldQueryMethods.GetAllInvolvements(accountID);
            if (involvements.Length > 0)
            {
                string cmdBase = String.Format("WHERE PostID = '{0}'", involvements[0].Posts_PostID);
                for (int x = 1; x < involvements.Length; x++)
                {
                    string postID = involvements[x].Posts_PostID;
                    cmdBase += String.Format(" || PostID = '{0}'", postID);
                }
                cmdBase += ";";

                var output = HelloWorldQueryMethods.GetAllPosts(cmdBase);

                MainPageGlobals.Posts = output;
                SetCards(-2);
            }
        }
        protected void profileBtn_Click(object sender, EventArgs e)
        {

        }

        protected void allEventsBtn_Click(object sender, EventArgs e)
        {
            allEventsBtn.Enabled = false;
            myEventBtn.Enabled = true;

            SetCards();
        }
    }
}