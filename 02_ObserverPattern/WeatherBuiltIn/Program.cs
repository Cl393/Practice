using System;
using System.Threading.Tasks;

namespace WeatherBuiltIn
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay();
            currentConditionDisplay.Subscribe(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            statisticsDisplay.Subscribe(weatherData);

            weatherData.NotifyObservers(new MeasurementData(25, 75, 120));
            Task.Delay(1000);
            weatherData.NotifyObservers(null);
            Task.Delay(1000);
            currentConditionDisplay.Unsubscribe();
            weatherData.NotifyObservers(new MeasurementData(23, 45, 104));
            weatherData.WeatherStationClose();

            Console.ReadLine();
        }
    }
}
