using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class WeatherSubscriberSystem
    {
        public WeatherSubscriberSystem(WeatherData weatherData, WeatherChangeArgs e)
        {
            weatherData.WeatherChange += new WeatherData.WeatherChangeEventHandler((new CurrentConditionDisplay()).Display);
            weatherData.WeatherChange += (new ForecastDisplay()).Display;
            weatherData.WeatherChange += (new FeelingToneDisplay()).Display;
            weatherData.RaiseWeatherChange(e);
        }

    }
}
