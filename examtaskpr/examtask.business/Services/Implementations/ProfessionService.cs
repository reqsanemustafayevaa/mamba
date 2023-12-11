using examtask.business.Services.Interfaces;
using examtask.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examtask.business.Services.Implementations
{
    public class ProfessionService : IProfessionService
    {
        public Task CreateAsync(Team entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Team>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Team> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Team genre)
        {
            throw new NotImplementedException();
        }
    }
}
