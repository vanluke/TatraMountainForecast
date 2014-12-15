using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IWeatherService
    {
        Task<IWeatherContainer> GetAsync();
        Task<IWeatherContainer> GetAsync(string city);
        Task UpdateAsync(IWeather wether);
        Task DeleteAsync(string city);
    }
}
