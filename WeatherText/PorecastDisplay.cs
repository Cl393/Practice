using System;
using System.Collections.Generic;
using System.Text;
using WeatherText.Interface;

namespace WeatherText
{
    public class PorecastDisplay : IObserver, IDisplayElement
    {
        public PorecastDisplay(ISubject weatherDataText)
        {
            weatherDataText.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("所以我不做人了，jojo");
        }

        public void Update(float a1, float b2, float c3)
        {
            Display();
        }
    }
}
