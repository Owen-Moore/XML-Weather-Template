using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, location, tempHigh, tempLow, 
            windSpeed, windDirection, precipitation, visibility;

        public int condition;
        public Image image;
        public Day()
        {
            date = currentTemp = currentTime = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = "";
        }
    }
}
