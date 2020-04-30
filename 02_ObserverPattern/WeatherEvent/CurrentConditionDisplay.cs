using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherEvent
{
    class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private WeatherChangeEventArgs _args;

        public CurrentConditionDisplay(WeatherData wd) 
        {
            wd.WeatherChange += this.Update;
        }

        public void Display()
        {
            Console.WriteLine(
                    $"Current condition: " +
                    $"温度：{_args.Temperature}C " +
                    $", 湿度：{_args.Humidity}% " +
                    $", 压力：{_args.Pressure} "
                    );
        }

        public void Update(object sender, WeatherChangeEventArgs args)
        {
            _args = args;
            Display();
        }
    }
}
