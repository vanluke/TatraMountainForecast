namespace Model.Interfaces
{
    public interface IWeatherDetails
    {
        double Temperature { get; set; }
        double MinTemperature { get; set; }
        double MaxTemperature { get; set; }
        double Pressure { get; set; }
        double SeaLevel { get; set; }
        double GroundLevel { get; set; }
        double Humidity { get; set; }
    }
}
