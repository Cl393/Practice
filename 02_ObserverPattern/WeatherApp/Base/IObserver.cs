﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Base
{

    public interface IObserver
    {
        // 气象之变化时，subject会把这些值更新给observers
        void Update(float temp, float humidity, float pressure);
    }
}
