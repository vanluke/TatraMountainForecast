using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IWetherService
    {
        Task<IEnumerable<IWether>> GetAsync();
        Task<IEnumerable<IWether>> GetAsync(int id);
        Task UpdateAsync(IWether wether);
        Task DeleteAsync(int id);
    }
}
