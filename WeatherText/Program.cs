using System;

namespace WeatherText
{
    class Program
    {
        static void Main(string[] args)
        {

            WeatherDataText weatherDataText = new WeatherDataText();

            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherDataText);
            ThirdPartyDisplay thirdParty = new ThirdPartyDisplay(weatherDataText);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherDataText);
            weatherDataText.SetMeasurements(20, 30, 40);
            Console.ReadLine();
        }
    }
}
