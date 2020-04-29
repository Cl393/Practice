using System;
using System.Runtime.InteropServices.ComTypes;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //主题
            WeatherData weatherData = new WeatherData();

            //观察者，将观察者置入主题的哈希集中（观察者列表）
       //         CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
       //     ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
      //      HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            //气象站数据发布
            Console.WriteLine("-------第1次数据发布-------");
            weatherData.SetMeasurements(10, 20, 30);
            Console.WriteLine("\n-------第2次数据发布-------");
            weatherData.SetMeasurements(14, 25, 36);
            Console.WriteLine("\n-------第3次数据发布-------");
            weatherData.SetMeasurements(40, 50, 60);
        }
    }
}
