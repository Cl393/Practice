using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Base;

namespace WeatherApp
{
    public class WeatherData:ISubject
    {                   //防止重复加入
        private readonly HashSet<IObserver> _observers;//存放观察者
        private float _temp, _humidity, _pressure;
        public WeatherData()
        {
            _observers = new HashSet<IObserver>();
        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temp, _humidity, _pressure);
            }
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}
