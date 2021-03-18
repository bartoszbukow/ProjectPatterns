using ProjectPatterns.Observer.Abstract;
using System;

namespace ProjectPatterns.Observer
{
    public class DisplayCurrentConditional : IObserver, IDisplayItem
    {
        public float temperature;
        public float humidity;
        private readonly ISubject weatherData;

        public DisplayCurrentConditional(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.AddObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Warunki biezace " + temperature + " stopni C oraz " + humidity + "% wilgotnosci");
        }
    }
}
