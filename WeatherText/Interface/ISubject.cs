using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherText.Interface
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observable);//订阅
        void RemoveObserver(IObserver observable);//取消
        void NotifyObservers();//通知
    }
}
