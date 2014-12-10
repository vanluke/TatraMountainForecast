using System.Collections.Generic;

namespace Model.Interfaces
{
    public interface IWeatherContainer
    {
        string Cod { get; set; }
        double Calctime { get; set; }
        int NumberOfLinesReturnedByApiCall { get; set; }
        IEnumerable<IForecast> Forecast { get; set; }
    }
}
