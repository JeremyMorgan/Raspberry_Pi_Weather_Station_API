using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherCenter.Models
{
    public class Reading
    {
        public float TempSensor1 { get; set; }
        public float TempSensor2 { get; set; }
        public float TempSensor3 { get; set; }
        public float TempSensorAvg { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public float Altitude { get; set; }
        public float SeaLevelPressure { get; set; }
        public float Lux { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}