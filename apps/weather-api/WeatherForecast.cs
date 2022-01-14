namespace NxDotnetWorkspace.WeatherApi;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    /// <summary>
    /// just to kick off the ci
    /// </summary>
    public string? Summary { get; set; }
}
