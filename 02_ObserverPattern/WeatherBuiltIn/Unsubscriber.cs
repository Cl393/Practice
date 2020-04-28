using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherBuiltIn
{
    class Unsubscriber : IDisposable
    {
        private readonly HashSet<IObserver<MeasurementData>> _observers;
        private readonly IObserver<MeasurementData> _observer;

        public Unsubscriber(HashSet<IObserver<MeasurementData>> observers, IObserver<MeasurementData> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}

