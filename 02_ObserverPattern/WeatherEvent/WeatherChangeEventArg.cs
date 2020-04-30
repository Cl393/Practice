using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherEvent
{
   public  class WeatherChangeEventArgs:EventArgs
    {
        public readonly float Temperature;
        public readonly float Humidity;
        public readonly float Pressure;
        public WeatherChangeEventArgs(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
    }
}
