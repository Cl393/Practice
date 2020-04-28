using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherBuiltIn
{
    public struct MeasurementData
    {
        public float Temperature { get; }
        public float Humidity { get; }
        public float Pressure { get; }

        public MeasurementData(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
    }
}
