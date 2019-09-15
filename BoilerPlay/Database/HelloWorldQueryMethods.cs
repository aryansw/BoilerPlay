using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoilerPlay.Database
{
    public static class HelloWorldQueryMethods
    {
        public static string[] GetAllInvolvementsForAccount(string accountID)
        {
            var output = Query.ExecuteReturnCommand(String.Format("SELECT * FROM HelloWorld.Involvements WHERE Accounts_ID = '{0}';", accountID));

            List<string> involvmentIDs = new List<string>();
            for (int x = 0; x < output.Rows.Count; x++)
            {
                involvmentIDs.Add(output.Rows[x].ItemArray[0].ToString());
            }
            return involvmentIDs.ToArray();
        }
        public static void InsertInvolvement(Involvement involvement)
        {
            int IsHost = 0;
            if (involvement.IsHost)
                IsHost = 1;

            string sqlStatement = String.Format("INSERT INTO HelloWorld.Involvements(Posts_PostID, Accounts_ID, IsHost) VALUES('{0}', '{1}', '{2}');", involvement.Posts_PostID, involvement.AccountsID, IsHost);

            Query.ExecuteNonReturnCommand(sqlStatement);
        }
        public static Involvement[] GetAllInvolvements(string AccountID)
        {
            var output = Query.ExecuteReturnCommand(String.Format("SELECT * FROM HelloWorld.Involvements WHERE Accounts_ID = '{0}';", AccountID));

            List<Involvement> posts = new List<Involvement>();
            for (int x = 0; x < output.Rows.Count; x++)
            {
                Involvement newInvolvement = new Involvement();
                newInvolvement.Posts_PostID = output.Rows[x].ItemArray[0].ToString();
                newInvolvement.AccountsID = output.Rows[x].ItemArray[1].ToString();

                int isHost = Convert.ToInt32(output.Rows[x].ItemArray[2].ToString());
                if (isHost > 0)
                    newInvolvement.IsHost = true;
                else
                    newInvolvement.IsHost = false;

                posts.Add(newInvolvement);
            }
            return posts.ToArray();
        }
        public static void DeleteInvolvement(string PostID)
        {
            string sqlStatement = String.Format("DELETE FROM HelloWorld.`Involvements` WHERE Posts_PostID = '{0}';", PostID);

            Query.ExecuteNonReturnCommand(sqlStatement);
        }
        public static void DeleteInvolvement(string PostID, string AccountID)
        {
            string sqlStatement = String.Format("DELETE FROM HelloWorld.`Involvements` WHERE Posts_PostID = '{0}' && Accounts_ID = '{1}';", PostID, AccountID);

            Query.ExecuteNonReturnCommand(sqlStatement);
        }
        public static void DeleteUserFromInvolvement(string AccountID)
        {
            string sqlStatement = String.Format("DELETE FROM HelloWorld.`Involvements` WHERE Accounts_ID = '{0}';", AccountID);

            Query.ExecuteNonReturnCommand(sqlStatement);
        }
        public static Posts[] GetAllPostsByLocation(string location)
        {
            var output = Query.ExecuteReturnCommand(String.Format("SELECT * FROM HelloWorld.Posts WHERE Location = '{0}';", location));

            List<Posts> posts = new List<Posts>();
            for (int x = 0; x < output.Rows.Count; x++)
            {
                Posts newPost = new Posts();
                newPost.PostID = output.Rows[x].ItemArray[0].ToString();
                newPost.Title = output.Rows[x].ItemArray[1].ToString();
                newPost.Posts_Name = output.Rows[x].ItemArray[2].ToString();
                newPost.DateTime = DateTime.Parse(output.Rows[x].ItemArray[3].ToString());
                newPost.Gender = output.Rows[x].ItemArray[4].ToString();
                newPost.Desc = output.Rows[x].ItemArray[5].ToString();
                newPost.Location = output.Rows[x].ItemArray[6].ToString();
                newPost.NumberNeeded = Convert.ToInt32(output.Rows[x].ItemArray[7].ToString());
                newPost.Proficiency = output.Rows[x].ItemArray[8].ToString();
                posts.Add(newPost);
            }
            return posts.ToArray();
        }
        public static Posts[] GetAllPosts()
        {
            var output = Query.ExecuteReturnCommand("SELECT * FROM HelloWorld.Posts");

            List<Posts> posts = new List<Posts>();
            for (int x = 0; x < output.Rows.Count; x++)
            {
                Posts newPost = new Posts();
                newPost.PostID = output.Rows[x].ItemArray[0].ToString();
                newPost.Title = output.Rows[x].ItemArray[1].ToString();
                newPost.Posts_Name = output.Rows[x].ItemArray[2].ToString();
                newPost.DateTime = DateTime.Parse(output.Rows[x].ItemArray[3].ToString());
                newPost.Gender = output.Rows[x].ItemArray[4].ToString();
                newPost.Desc = output.Rows[x].ItemArray[5].ToString();
                newPost.Location = output.Rows[x].ItemArray[6].ToString();
                newPost.NumberNeeded = Convert.ToInt32(output.Rows[x].ItemArray[7].ToString());
                newPost.Proficiency = output.Rows[x].ItemArray[8].ToString();
                posts.Add(newPost);
            }
            return posts.ToArray();
        }
        public static Posts[] GetAllPosts(string WhereClause)
        {
            var output = Query.ExecuteReturnCommand("SELECT * FROM HelloWorld.Posts " + WhereClause);

            List<Posts> posts = new List<Posts>();
            for (int x = 0; x < output.Rows.Count; x++)
            {
                Posts newPost = new Posts();
                newPost.PostID = output.Rows[x].ItemArray[0].ToString();
                newPost.Title = output.Rows[x].ItemArray[1].ToString();
                newPost.Posts_Name = output.Rows[x].ItemArray[2].ToString();
                newPost.DateTime = DateTime.Parse(output.Rows[x].ItemArray[3].ToString());
                newPost.Gender = output.Rows[x].ItemArray[4].ToString();
                newPost.Desc = output.Rows[x].ItemArray[5].ToString();
                newPost.Location = output.Rows[x].ItemArray[6].ToString();
                newPost.NumberNeeded = Convert.ToInt32(output.Rows[x].ItemArray[7].ToString());
                newPost.Proficiency = output.Rows[x].ItemArray[8].ToString();
                posts.Add(newPost);
            }
            return posts.ToArray();
        }
        public static void DeleteAccount(string accountID)
        {
            Query.ExecuteNonReturnCommand(String.Format("DELETE FROM HelloWorld.Accounts WHERE ID = {0};", accountID));
        }
        public static int GetNumberOfPeopleInEvent(string PostID)
        {
            var output = Query.ExecuteReturnCommand(String.Format("SELECT * FROM HelloWorld.Involvements WHERE Posts_PostID = {0}", PostID));
            return output.Rows.Count;
        }
        public static void DeletePostRow(string postID)
        {
            Query.ExecuteNonReturnCommand(String.Format("DELETE FROM HelloWorld.Posts WHERE PostID = {0};", postID));
        }
        public static void IncrementNumberOfAttendees(string PostID)
        {
            var output = Query.ExecuteReturnCommand(String.Format("SELECT HelloWorld.Posts.NumberNeeded FROM HelloWorld.Posts WHERE HelloWorld.Posts.PostID = '{0}';", PostID));
            int currentNumberNeeded = Convert.ToInt32(output.Rows[0].ItemArray[0].ToString());
            currentNumberNeeded++;

            string sqlStatement = String.Format("UPDATE HelloWorld.Posts " +
                "SET " +
                "HelloWorld.Posts.NumberNeeded = '{0}' " +
                "WHERE " +
                "HelloWorld.Posts.PostID = '{1}';", currentNumberNeeded, PostID);

            Query.ExecuteNonReturnCommand(sqlStatement);
        }
        public static string CreatePostInDataBase(Posts postToAdd)
        {
            string dateTimeString = postToAdd.DateTime.ToString("yyyy-MM-dd hh:mm:ss") + ".000";//2018-09-08 17:51:04.000

            int newPostID = GenerateNewPostID();
            Query.ExecuteNonReturnCommand(String.Format("INSERT INTO {0}({0}.PostID, {0}.Title, {0}.Host_Name, {0}.DateTime, {0}.Gender, {0}.Desc, {0}.Location, {0}.NumberNeeded, {0}.Proficiency) " +
                "VALUES ('{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');",
                "HelloWorld.Posts",
                newPostID,
                postToAdd.Title,
                postToAdd.Posts_Name,
                dateTimeString,
                postToAdd.Gender,
                postToAdd.Desc,
                postToAdd.Location,
                postToAdd.NumberNeeded,
                postToAdd.Proficiency));

            return newPostID.ToString();
        }
        public static int GenerateNewPostID()
        {
            var postIDs = Query.ExecuteReturnCommand("SELECT HelloWorld.Posts.PostID FROM HelloWorld.Posts");
            int highestPostNumber = 0;
            for (int x = 0; x < postIDs.Rows.Count; x++)
            {
                int number = Convert.ToInt32(postIDs.Rows[x].ItemArray[0].ToString());
                if(number > highestPostNumber)
                    highestPostNumber = number;
            }
            return highestPostNumber + 1;
        }
        public static int GenerateNewProfileID()
        {
            var ProfileID = Query.ExecuteReturnCommand("SELECT HelloWorld.Accounts.ID FROM HelloWorld.Accounts ORDER by ID asc");
            return Convert.ToInt32(ProfileID.Rows[ProfileID.Rows.Count-1].ItemArray[0].ToString()) + 1;
        }
        public static Account GetAccountFromCookie(HttpRequest Request, HttpResponse Response)
        {
            string cookieValue = Cookies.ReadCookie(Request, Response);
            var output = Query.ExecuteReturnCommand(String.Format("SELECT * FROM HelloWorld.Accounts WHERE ID = '{0}'", cookieValue));
            Account account = new Account
            {
                ID = output.Rows[0].ItemArray[0].ToString(),
                Name = output.Rows[0].ItemArray[1].ToString(),
                Year = Convert.ToInt32(output.Rows[0].ItemArray[2].ToString()),
                Desc = output.Rows[0].ItemArray[3].ToString(),
                Password= output.Rows[0].ItemArray[4].ToString(),
                Email = output.Rows[0].ItemArray[5].ToString(),
                Phone = output.Rows[0].ItemArray[6].ToString()
            };
            return account;
        }

        public static Account GetAccountFromID(String Id)
        {
            string cookieValue = Id;
            var output = Query.ExecuteReturnCommand(String.Format("SELECT * FROM HelloWorld.Accounts WHERE ID = '{0}'", cookieValue));
            Account account = new Account
            {
                ID = output.Rows[0].ItemArray[0].ToString(),
                Name = output.Rows[0].ItemArray[1].ToString(),
                Year = Convert.ToInt32(output.Rows[0].ItemArray[2].ToString()),
                Desc = output.Rows[0].ItemArray[3].ToString(),
                Password = output.Rows[0].ItemArray[4].ToString(),
                Email = output.Rows[0].ItemArray[5].ToString(),
                Phone = output.Rows[0].ItemArray[6].ToString()
            };
            return account;
        }

        public static Posts GetPostsFromPostID(string post_id)
        {
            var output = Query.ExecuteReturnCommand(String.Format("SELECT * FROM HelloWorld.Posts WHERE PostID = '{0}'", post_id));
            Posts newpost = new Posts
            {
                PostID = output.Rows[0].ItemArray[0].ToString(),
                Title = output.Rows[0].ItemArray[1].ToString(),
                Posts_Name = output.Rows[0].ItemArray[2].ToString(),
                DateTime = DateTime.Parse(output.Rows[0].ItemArray[3].ToString()),
                Gender = output.Rows[0].ItemArray[4].ToString(),
                Desc = output.Rows[0].ItemArray[5].ToString(),
                Location = output.Rows[0].ItemArray[6].ToString(),
                NumberNeeded = Convert.ToInt32(output.Rows[0].ItemArray[7].ToString()),
                Proficiency = output.Rows[0].ItemArray[8].ToString()
                
            };
            return newpost;
        }

        public static void UpdateAccount(Account acc)
        {
            //Database.Query.ExecuteNonReturnCommand("Update Accounts VALUES('" + ID + "','" + Name + "');
            Query.ExecuteNonReturnCommand("DELETE FROM `HelloWorld`.`Accounts` WHERE (`ID` = '"+acc.ID+"');");
            Query.ExecuteNonReturnCommand(String.Format("INSERT INTO HelloWorld.Accounts " +
                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",
                    acc.ID,
                    acc.Name,
                    acc.Year,
                    Register.FixApostrophe(acc.Desc),
                    acc.Password,
                    acc.Email,
                    acc.Phone));
        }
        public static int IntfromYear(string s)
        {
            switch (s)
            {
                case "Freshman":
                    return 0;
                case "Sophomore":
                    return 1;
                case "Junior":
                    return 2;
                case "Senior":
                default:
                    return 3;
            }
        }
        public static string YearfromInt(int  x)
        {
            switch (x)
            {
                case 1:
                    return "Freshman";
                case 2:
                    return "Sophomore";
                case 3:
                    return "Junior";
                case 4:
                default:
                    return "Senior";
            }
        }
        public struct Involvement
        {
            public string Posts_PostID;
            public string AccountsID;
            public bool IsHost;
        }

        public struct Account
        {
            public string ID;
            public string Name;
            public int Year;
            public string Desc;
            public string Password;
            public string Email;
            public string Phone;
        }
        public struct Posts
        {
            public string PostID;
            public string Title;
            public string Posts_Name;
            public DateTime DateTime;
            public string Gender;
            public string Desc;
            public string Location;
            public int NumberNeeded;
            public string Proficiency;
        }
    }
}