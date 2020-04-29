using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class ForecastDisplay : IWeatherStationSubject
    {
        public void Display(object sender, WeatherChangeArgs e)
        {
            Console.WriteLine("Tomorrow weather condition: " + e.temperature*1.1 + " degree ," + e.humidity*0.9 + "% humidity");
        }
    }
}
