using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Base
{
    /// <summary>
    /// 主题（发布者）接口
    /// </summary>
    public interface ISubject
    {
        // 订阅
        void RegisterObserver(IObserver observer);

        // 取消订阅
        void RemoveObserver(IObserver observer);

        // 状态变化时，通知所有观察者
        void NotifyObservers();
    }
}
