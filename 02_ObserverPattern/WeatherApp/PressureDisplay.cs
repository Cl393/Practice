using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Base;

namespace WeatherApp
{
    public class PressureDisplay : IObserver, IDisplayElement
    {
        private float _temp;
        private int num;
        private float _pressure;

        public PressureDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"当前温度为{_temp},次数为{num},压强为:{_pressure}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temp = temp;
            num++;
            _pressure = pressure;
            Display();
        }
    }
}
