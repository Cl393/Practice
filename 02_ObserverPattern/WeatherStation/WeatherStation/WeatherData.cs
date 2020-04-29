using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    // publisher ： 
    public class WeatherData
    {
        // declare an event
        public  delegate void WeatherChangeEventHandler(object sender, WeatherChangeArgs e);
        public event WeatherChangeEventHandler WeatherChange;

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            var args = new WeatherChangeArgs(temperature, humidity, pressure);
            onWeatherChange(args);
        }

        // 虚函数的作用是什么？ 保护之后的作用？
        protected  virtual void onWeatherChange(WeatherChangeArgs e)
        {
            WeatherChange?.Invoke(this, e);
        }


    }

    public class WeatherChangeArgs : EventArgs
    {
        public  readonly double temperature;
        public  readonly double humidity;
        public  readonly double pressure;
        public WeatherChangeArgs(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }
    }
}
