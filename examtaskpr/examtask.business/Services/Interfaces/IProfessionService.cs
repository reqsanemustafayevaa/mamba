using examtask.core.Repostories.Interfaces;
using examtask.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examtask.business.Services.Interfaces
{
    public interface IProfessionService
    {
        Task CreateAsync(Team entity);
        Task Delete(int id);
        Task<Team> GetByIdAsync(int id);
        Task<List<Team>> GetAllAsync();
        Task UpdateAsync(Team genre);
    }
}
