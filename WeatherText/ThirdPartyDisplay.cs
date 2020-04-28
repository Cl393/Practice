using System;
using System.Collections.Generic;
using System.Text;
using WeatherText.Interface;

namespace WeatherText
{
    public class ThirdPartyDisplay : IObserver, IDisplayElement
    {
        public ThirdPartyDisplay(ISubject weatherDataText)
        {
            weatherDataText.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("你到底想说什么");
        }

        public void Update(float a1, float b2, float c3)
        {

            Display();
        }
    }
}
