using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherBuiltIn
{
    class CurrentConditionDisplay : IObserver<MeasurementData>
    {
        private IDisposable _unsubscriber;
      
        // 订阅　 
        public virtual void Subscribe(IObservable<MeasurementData> provider)
        {
            if (provider != null)
                _unsubscriber = provider.Subscribe(this);
        }

        public void OnError(Exception error)
        {
            var original = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CurrentCondition数据获取错误！");
            Console.ForegroundColor = original;
        }

        public void OnNext(MeasurementData value)
        {
            Console.WriteLine(
                $"Current condition: " +
                $"\n温度：{value.Temperature}C " +
                $"\n湿度：{value.Humidity}% " +
                $"\n压力：{value.Pressure} ");
        }

        public void OnCompleted()
        {
            Console.WriteLine("CurrentCondition 任务完成");
            Unsubscribe();
        }

        // 取消订阅
        public virtual void Unsubscribe()
        {
            Console.WriteLine("CurrentCondition 取消订阅");
            _unsubscriber.Dispose();
        }
    }
}
