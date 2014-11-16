using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;

namespace Service
{
    public class WhetherService : IWetherService
    {
        public Task<IEnumerable<IWether>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IWether>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(IWether wether)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
