using System.Net.NetworkInformation;

namespace _7_5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obj obj = new Obj();
            Console.Write(Obj.Parent);
        }
    }
    class Obj
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;
        static Obj() 
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }
}
