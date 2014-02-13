using System;

namespace DependencyInjection_Worksheet
{
    public class Program
    {       
        public static void Main()
        {
            var dateGenerator = new DateGenerator();
            var publicHolidayNotifier = new PublicHolidayNotifier(dateGenerator);

            var startup = new StartupService(publicHolidayNotifier, new FileWriter("Hello.txt"));
            startup.Initiate();
            Console.ReadLine();
        }
         
    }
}