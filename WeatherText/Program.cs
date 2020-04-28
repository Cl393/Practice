using System;

namespace WeatherText
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherDataText t1, t2, t3, t4;

            t1 = new WeatherDataText();
            t2 = new WeatherDataText();
            t3 = new WeatherDataText();
            t4 = new WeatherDataText();
            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(t1);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(t2);
            ThirdPartyDisplay thirdPartyDisplay = new ThirdPartyDisplay(t3);
            PorecastDisplay porecastDisplay = new PorecastDisplay(t4);
            t1.SetMeasurements(20, 30, 40);
            t1.SetMeasurements(32, 36, 30);
            t2.SetMeasurements(1,2,3);
            t3.SetMeasurements(4,5,6);
            t4.SetMeasurements(7,8,9);
            Console.ReadLine();
        }
    }
}
