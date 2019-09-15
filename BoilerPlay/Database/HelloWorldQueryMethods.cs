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
        public static void CreatePostInDataBase(Posts postToAdd)
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