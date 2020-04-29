using System;

namespace WeatherEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData= new WeatherData();
            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
           
            Console.WriteLine("-------第1次数据发布-------");
            weatherData.SetMeasurements(10, 20, 30);
            Console.WriteLine("\n-------第2次数据发布-------");
            weatherData.SetMeasurements(14, 25, 36);
            Console.WriteLine("\n-------第3次数据发布-------");
            weatherData.SetMeasurements(40, 50, 60);
        }
    }
}
