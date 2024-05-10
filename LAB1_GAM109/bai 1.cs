using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Gam109
{
    public static class UserData
    {
        public static string ID;
        public static string UserName;
        public static float Health;
        public static int Point;

        static UserData()
        {
            ID = "2024";
            UserName = "first";
            Health = 0;
            Point = 0;
        }
        public static void ShowData()
        {
            Console.WriteLine("Id: " + ID);
            Console.WriteLine("UserName: " + UserName);
        }
    }
    public class Program
    {
        public static int Main(string[] args)
        {
            UserData.ShowData();
            return 0;
        }
    }
}
