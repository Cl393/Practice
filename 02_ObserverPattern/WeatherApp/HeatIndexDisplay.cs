using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Base;

namespace WeatherApp
{
    /// <summary>
    /// 酷热指数布告板
    /// </summary>
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {

        private float heatIndex = 0.0f;
        public HeatIndexDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"HeatIndexDisplay： {heatIndex}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            heatIndex = ComputeHeatIndex(temp, humidity);
            Display();
        }
        private float ComputeHeatIndex(float t, float h)
        {
            return 
                (float)((16.923 + (0.185212 * t) + (5.37941 * h) - (0.100254 * t * h)
            + (0.00941695 * Math.Pow(t,2) + (0.00728898 *Math.Pow(h,2)) 
            + (0.000345372 * (Math.Pow(t, 2) * h)) - (0.000814971 * (t * Math.Pow(h, 2))) 
            + (0.0000102102 * (Math.Pow(t, 2) * Math.Pow(h, 2))) - (0.000038646 * Math.Pow(t, 3)) 
            + (0.0000291583 * Math.Pow(h, 3)) + (0.00000142721 * (Math.Pow(t, 3) * h)) 
            + (0.000000197483 * (t * Math.Pow(h, 3))) - (0.0000000218429 * Math.Pow(t, 2) * Math.Pow(h, 2)) 
            + 0.000000000843296 * Math.Pow(t, 2) * Math.Pow(h, 3))) - (0.0000000000481975 * Math.Pow(t, 3) * Math.Pow(h, 3)));
        }
    }
}
