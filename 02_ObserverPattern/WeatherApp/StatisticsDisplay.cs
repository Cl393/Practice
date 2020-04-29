using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Base;

namespace WeatherApp
{
    /// <summary>
    /// 统计布告板
    /// </summary>
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;//最大
        private float minTemp =200f;  //最小
        private float tempSum = 0.0f; //累加和变量
        private int numReadings;//次数

        public StatisticsDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            string average=(tempSum / numReadings).ToString("#.#");
            Console.WriteLine($"StatisticsDisplay:" +
                $"平均气温：{average}℃" +
                $"，最高气温：{maxTemp}℃" +
                $"，最低气温：{ minTemp}℃");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
            }

            Display();
        }
    }
}
