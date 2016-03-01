using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH02_TheObserver
{
    class HeatIndexDisplay : IDisplayElement, IObserver
    {
        private float temperature;
        private float humidity;

        private float heatIndex;

        private ISubject weatherData;


        public HeatIndexDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;

            CalculateHeatIndex();

            Display();
        }


        private void CalculateHeatIndex()
        {
            double T = temperature;
            double RH = humidity;

            heatIndex = (float)(
                        -42.379f + (2.040901523 * T) + (10.14333127 * RH) -
                        (0.22475541 * T * RH) -(6.83783d * Math.Pow(10, -3) * T) -
                        (5.481717 * Math.Pow(10, -2) * RH) + (1.22874 * Math.Pow(10, -3) * RH) +
                        (8.5282 * Math.Pow(10, -4) * T * Math.Pow(RH, 2)) - (1.99 * Math.Pow(10, -6) * Math.Pow(T, 2) * Math.Pow(RH, 2)) 
                        );
        }
        public void Display()
        {
            Console.WriteLine("Heat index is: {0}", heatIndex);
        }

        
    }
}
