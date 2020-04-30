using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Base;

namespace WeatherApp
{
    public class TestDisplay : IObserver,IDisplayElement
    {

        private float _temp;
        public TestDisplay(ISubject weatherData) 
        {
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine(_temp);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temp = temp;
           
            Display();
        }
    }
}
