using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherSubscriberSystem sys_1 = new WeatherSubscriberSystem(new WeatherData(), new WeatherChangeArgs(20, 18.6, 55));
            Console.WriteLine("\n");
            WeatherSubscriberSystem sys_2 = new WeatherSubscriberSystem(new WeatherData(), new WeatherChangeArgs(35, 24, 38));
            Console.ReadKey();
        }
    }
}
