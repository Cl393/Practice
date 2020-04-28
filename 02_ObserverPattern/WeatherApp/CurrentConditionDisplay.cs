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
            Console.WriteLine($"当前状况：{_temp}℃ 和 {_humidity}% 湿度");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;
            Display();
        }
    }
}
