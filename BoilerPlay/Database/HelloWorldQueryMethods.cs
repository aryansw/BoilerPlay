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
                posts.Add(newPost);
            }
            return posts.ToArray();
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
        }
    }
}