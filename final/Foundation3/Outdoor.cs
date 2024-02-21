using System;
using System.Collections.Generic;

public class Outdoor : Event
{

    private string _weather;

    public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
    : base(title, description, date, time, address)
    {

        _weather = weatherForecast;
        
    }

    public string WeatherForecast
    {

        get { return _weather; }
        set { _weather = value; }

    }

    public override string GetFullDetails()
    {

        string baseDetails = GetStandardDetails();
        return $"{baseDetails}\nType: Outdoor Gathering\nWeather Forecast: {_weather}";
        
    }
}