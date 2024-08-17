namespace swagger
{
    public class WeatherForecast
    {
        // <Summery>
        // Temp
        //Date
        public DateOnly Date { get; set; }
        // <Summery>
        // Temp In C
        //Date

        public int TemperatureC { get; set; }
        // <Summery>
        // Temp In F
        //Date

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        // <Summry>
        // Temp In Summery
        //Date
        public string? Summary { get; set; }
    }
}
