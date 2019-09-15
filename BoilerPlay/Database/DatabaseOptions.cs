using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoilerPlay.Database
{
    public class DatabaseOptions
    {
        public static class Posts_Gender
        {
            public static readonly string Male = "Male";
            public static readonly string Female = "Female";
            public static readonly string Everyone = "Everyone";
            public static string[] SportsCombinations =
            {
                Male,Female,Everyone
            };
        }
        public static class Posts_Proficiency
        {
            public static readonly string Beginner = "Beginner";
            public static readonly string Amateur = "Amateur";
            public static readonly string Skilled = "Skilled";
            public static readonly string Expert = "Expert";
            public static string[] SportsCombinations =
            {
                Beginner,Amateur,Skilled,Expert
            };
        }
        public static class Posts_Sports
        {
            public static readonly string TableTennis = "Table Tennis";
            public static readonly string Tennis = "Tennis";
            public static readonly string Cricket = "Cricket";
            public static readonly string Football = "Football";
            public static readonly string Basketball = "Basketball";
            public static readonly string Baseball = "Baseball";
            public static readonly string Softball = "Softball";
            public static readonly string Pool = "Pool";
            public static readonly string Run = "Run";
            public static readonly string Soccer = "Soccer";
            public static readonly string Air_Hockey = "Air Hockey";
            public static readonly string Cardgames = "Cardgames";

            public static string[] SportsCombinations =
            {
                TableTennis,Tennis,Cricket,Football,Basketball,Baseball, Softball, Pool, Run, Soccer, Air_Hockey,Cardgames

            };
        }
        public static class Account_Year
        {
            public static readonly int Freshman = 0;
            public static readonly int Sophomore = 1;
            public static readonly int Junior = 2;
            public static readonly int Senior = 3;
        }
    }
}