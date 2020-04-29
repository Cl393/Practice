using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface IWeatherStationSubject
    {
        void Display(object sender, WeatherChangeArgs e);
    }
}
