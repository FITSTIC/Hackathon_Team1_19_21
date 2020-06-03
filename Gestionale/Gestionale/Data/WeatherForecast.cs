using System;
using System.ComponentModel.DataAnnotations;

namespace Gestionale.Data
{
    public class WeatherForecast
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
        public WeatherForecast() { }
    }
}
