using System;
using System.Collections.Generic;
using System.Text;
using WeatherText.Interface;

namespace WeatherText
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float A1, B2;

        public CurrentConditionDisplay(ISubject weatherDataText)
        {
            weatherDataText.RegisterObserver(this);
        }//给订阅者发布
        /// </summary>
        public void Display()//布告栏显示
        {
            Console.WriteLine($"当前状况：{A1}℃ 和 {B2}% 湿度");
        }

        public void Update(float a1, float b2, float c3)
        {
            A1 = a1;
            B2 = b2;
            Display();
        }
    }
}
