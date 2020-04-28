using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Base
{
   /// <summary>
   /// 观察者接口
   /// </summary>
    public interface IObserver
    {
        // 气象之变化时，subject会把这些值更新给observers
        void Update(float temp, float humidity, float pressure);
    }
}
