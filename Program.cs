using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, " + args[0] + " : " + DateTime.Now.DayOfWeek);
        }
    }
}
