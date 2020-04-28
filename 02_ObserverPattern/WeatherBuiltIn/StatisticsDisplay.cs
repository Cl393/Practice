using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherBuiltIn
{
    class StatisticsDisplay : IObserver<MeasurementData>
    {

        private IDisposable _unsubscriber;

        public virtual void Subscribe(IObservable<MeasurementData> provider)
        {
            if (provider != null)
                _unsubscriber = provider.Subscribe(this);
        }

        public void OnCompleted()
        {
            Console.WriteLine("Statistics 任务完成");
            Unsubscribe();
        }


        public virtual void Unsubscribe()
        {
            Console.WriteLine("Statistics 取消订阅");
            _unsubscriber.Dispose();
        }


        public void OnError(Exception error)
        {
            var original = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Statistics数据获取错误!");
            Console.ForegroundColor = original;
        }

        public void OnNext(MeasurementData value)
        {
            Console.WriteLine($"Statistics: {value.Temperature}, {value.Humidity}, {value.Pressure}.");
        }
    }
}
