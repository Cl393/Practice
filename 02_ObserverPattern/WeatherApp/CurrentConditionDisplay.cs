using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Base;

namespace WeatherApp
{
    /// <summary>
    /// 当前状况布告板
    /// </summary>
 public  class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float _temp, _humidity;
        public CurrentConditionDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }
        // 这个布告板只显示温度和湿度
        public void Display()
        {
            Console.WriteLine($"CurrentConditionDisplay：温度{_temp}℃ 和 湿度{_humidity}% ");
        }
        public void Update(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;

            Display();
        }
    }
}
