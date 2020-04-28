using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherBuiltIn
{
    public class WeatherData : IObservable<MeasurementData>
    {
        private readonly HashSet<IObserver<MeasurementData>> _observers;

        public WeatherData()
        {
            _observers = new HashSet<IObserver<MeasurementData>>();
        }

        //订阅用户，并返回可取消订阅的对象
        public IDisposable Subscribe(IObserver<MeasurementData> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscriber(_observers, observer);
        }

        // 发布通知
        public void NotifyObservers(MeasurementData? data)
        {
            foreach (var observer in _observers)
            {
                if (!data.HasValue)
                {
                    observer.OnError(new Exception("No value!!!"));
                }
                else
                {
                    observer.OnNext(data.Value);
                }
            }
        }

        // 关闭这个Subject
        public void WeatherStationClose()
        {
            foreach (var observer in _observers.ToArray())
            {
                observer.OnCompleted();
            }
            _observers.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The weather station 关闭");
        }
    }
}
