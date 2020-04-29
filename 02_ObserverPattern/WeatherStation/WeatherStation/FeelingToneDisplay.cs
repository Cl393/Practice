using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class FeelingToneDisplay : IWeatherStationSubject
    {
        public void Display(object sender, WeatherChangeArgs e)
        {
            if (e.temperature > 30)
            {
                Console.Write("The temperature is {0}, summer is coming", e.temperature);
            }
            else
            {
                Console.Write("The temperature is {0}, not bad, ha", e.temperature);
            }
        }
    }
}
