using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Implementation;

namespace Model.Interfaces
{
    public interface IWeatherService
    {
        Task<IEnumerable<Weather>> GetAsync();
        Task<Weather> GetAsync(string city);
        Task UpdateAsync(Weather wether);
        Task DeleteAsync(string city);
        Task<IUserLocation> GetCurrentLocalization(string hostname);
    }
}
