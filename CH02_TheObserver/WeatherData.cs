using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_TheObserver
{
    class WeatherData : ISubject
    {
        private List<IObserver> observers;

        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }


        public void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            measurementsChanged();

        }


        #region ISubject interface Methods
        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                if (observer != null)
                    observer.Update(temperature, humidity, pressure);
            }
        }

        #endregion

    }
}
