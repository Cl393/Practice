using System;
using System.Collections.Generic;
using System.Text;
using WeatherText.Interface;

namespace WeatherText
{
   public class WeatherDataText:ISubject
    {
        private readonly HashSet<IObserver> observers;
        private float A1, B2, C3;

        public WeatherDataText()
        {
            observers = new HashSet<IObserver>();
        }
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
       public  void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(A1,B2 ,C3 );
            }
        }//判断内容,更新

        public void MeasurementsChanged()//检测变化，调用变更方法
        {
            NotifyObservers();
        }
        public void SetMeasurements(float a1, float b2, float c3)
        {
            A1 = a1;
            B2 = b2;
            C3 = c3;
            MeasurementsChanged();
        }
    }
}
