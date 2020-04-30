using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherEvent
{
    /// <summary>
    /// 主题/发布者
    /// </summary>
    public class WeatherData
    {
        public event EventHandler<WeatherChangeEventArgs> WeatherChange;
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            var args = new WeatherChangeEventArgs(temperature, humidity, pressure);
            OnWeatherChange(args);
        }
        protected virtual void OnWeatherChange(WeatherChangeEventArgs args)
        {
            WeatherChange?.Invoke(this, args);
        }
    }
}
