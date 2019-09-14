using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoilerPlay.Database
{
    public class DatabaseOptions
    {
        public static class Posts_Gender {
            public static readonly string Male = "Male";
            public static readonly string Female = "Female";
            public static readonly string Everyone = "Everyone";
        }
        public static class Posts_Proficiency
        {
            public static readonly string Beginner = "Beginner";
            public static readonly string Amateur = "Amateur";
            public static readonly string Skilled = "Skilled";
            public static readonly string Professional = "Professional";
        }
    }
}