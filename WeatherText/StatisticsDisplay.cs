using System;
using System.Collections.Generic;
using System.Text;
using WeatherText.Interface;

namespace WeatherText
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        public StatisticsDisplay(ISubject weatherDataText)
        {
            weatherDataText.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("人类是有极限的,人越是玩弄计谋，计谋就越可能因意料之外的情况而失败，所以要成为超人的存在才行");
        }

        public void Update(float a1, float b2, float c3)
        {
            
            Display();
        }
    }
}
