using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherData2._0.Models
{
    public class DayAvr
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float IndoorTemperature { get; set; }
        public int IndoorHumidity { get; set; }
        public float OutdoorTemperature { get; set; }
        public int OutdoorHumidity { get; set; }

    }
}
