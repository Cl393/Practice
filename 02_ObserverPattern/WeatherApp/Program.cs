using System;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
           // StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            // XxxDisplay1 xxxDisplay1 = new XxxDisplay1(weatherData);

            weatherData.SetMeasurements(10, 20, 30);
            weatherData.SetMeasurements(14, 25, 36);
            weatherData.SetMeasurements(40, 50, 60);

            Console.ReadLine();
        }
    }
}
