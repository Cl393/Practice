using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherText.Interface
{
    public interface IObserver
    {
        void Update(float a1, float b2, float c3);
    }
}
