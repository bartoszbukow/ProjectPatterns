using ProjectPatterns.Observer.Abstract;
using System.Collections;

namespace ProjectPatterns.Observer
{
    class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void DeleteObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            for (var i = 0; i < observers.Count; i++)
            {
                ((IObserver)observers[i]).Update(temperature, humidity, pressure);
            }
        }

        public void ReadChanges()
        {
            NotifyObservers();
        }

        public void SetReadings(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            ReadChanges();
        }
    }
}
