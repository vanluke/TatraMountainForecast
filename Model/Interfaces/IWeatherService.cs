using System.Collections.Generic;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IWeatherService
    {
        Task<IEnumerable<IWether>> GetAsync();
        Task<IEnumerable<IWether>> GetAsync(int id);
        Task UpdateAsync(IWether wether);
        Task DeleteAsync(int id);
        Task<IUserLocation> GetCurrentLocalization(string hostname);
    }
}
