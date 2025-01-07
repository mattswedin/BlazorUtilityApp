namespace UtilityBlazorApp.Models
{
    public class WeatherDetails
    {
        //"main" is a reference from the OpenWeather API JSON response
        public Tempature? Main { get; set; }
        public List<WeatherCondition>? Weather { get; set; }
    }

    public class Tempature
    {
        public double? Temp { get; set; }
    }

    public class WeatherCondition
    {
        public string? Main { get; set; }
        public string? Icon { get; set; }
    }

}