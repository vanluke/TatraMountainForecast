using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Implementation;

namespace Model.Interfaces
{
    public interface IWeatherService
    {
        Task<IWeatherContainer> GetAsync();
        Task<IWeatherContainer> GetAsync(string city);
        Task UpdateAsync(Weather wether);
        Task DeleteAsync(string city);
    }
}
