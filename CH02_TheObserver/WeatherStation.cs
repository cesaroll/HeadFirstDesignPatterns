using System;
using System.Collections.Generic;
using System.Threading;

namespace CH02_TheObserver
{
    class WeatherStation
    {
        static void Main(string[] args)
        {

            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f); Thread.Sleep(800);
            weatherData.setMeasurements(82, 70, 29.2f); Thread.Sleep(1500);
            weatherData.setMeasurements(78, 90, 29.3f); Thread.Sleep(1800);


        }
    }
}
