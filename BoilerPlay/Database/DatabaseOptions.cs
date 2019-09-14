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
        public static class Posts_Sports
        {
            public static readonly string Table_Tennis = "Table Tennis";
            public static readonly string Tennis = "Tennis";
            public static readonly string Football = "Football";
            public static readonly string Cricket = "Cricket";
            public static readonly string Basketball = "Basketball";
            public static readonly string Pool = "Pool";
            public static readonly string Air_Hockey = "Air_Hockey";
            public static readonly string Cardgames = "Cardgames";
        }
    }
}