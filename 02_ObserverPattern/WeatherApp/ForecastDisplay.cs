using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Base;

namespace WeatherApp
{
    /// <summary>
    /// 天气预告布告板
    /// </summary>
    class ForecastDisplay : IObserver, IDisplayElement
    {

        private float currentPressure = 29.92f;  //当前的气压
        private float lastPressure; // 最后的气压

        public ForecastDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("ForecastDisplay：气压升高，天气转好！");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("ForecastDisplay：气压不变，天气维持！");
            }
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("ForecastDisplay：气压降低，天气变坏！");
            }
        }

        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;// 将当前的气压赋给最后的气压
            currentPressure = pressure;// 将更新的气压赋给当前气压
            Display();

        }
    }
}
