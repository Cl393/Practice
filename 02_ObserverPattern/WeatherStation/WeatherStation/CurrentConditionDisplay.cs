using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class CurrentConditionDisplay : IWeatherStationSubject
    {
        public  void Display(object sender, WeatherChangeArgs e)
        {
            Console.WriteLine("Current conditons:" + e.temperature + "degreees and " + e.humidity + "% humidity" );
        }
    }
}
