using System;
using System.Collections.Generic;
using System.Text;
using WeatherText.Interface;

namespace WeatherText
{
    public class PorecastDisplay : IObserver, IDisplayElement
    {
        private float A1, B2;
        float[] temp = new float[] { };
        public PorecastDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        // 这个布告板只显示温度和湿度
        public void Display()
        {
            Console.WriteLine($"最小:{ A1}℃ 和 {B2}% 湿度");

        }

        public void Update(float temp, float humidity, float pressure)
        {
            //温度湿度
            A1 = temp;
            B2 = humidity;
            Display();
        }
        private IDisposable _unsubscriber;



        public void OnCompleted()
        {
            Console.WriteLine("Statistics 任务完成");
            Unsubscribe();
        }


        public virtual void Unsubscribe()
        {
            Console.WriteLine("Statistics 取消订阅");
            _unsubscriber.Dispose();
        }
    }
}
