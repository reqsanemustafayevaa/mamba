using examtask.business.Services.Interfaces;
using examtask.core.Repostories.Interfaces;
using examtask.MVC.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace examtask.business.Services.Implementations
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepostory _teamrepostory;
        public TeamService(ITeamRepostory teamrepostory)
        {
            _teamrepostory=teamrepostory;
        }
        public async Task CreateAsync(Team entity)
        {
            if (_teamrepostory.Table.Any(x => x.Name == entity.Name))
                throw new NullReferenceException();

            await _teamrepostory.CreateAsync(entity);
            await _teamrepostory.CommitAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _teamrepostory.GetByIdAsync(id);
            if (entity is null) throw new NullReferenceException();

            _teamrepostory.Delete(entity);
            await _teamrepostory.CommitAsync();

        }

        public async Task<List<Team>> GetAllAsync()
        {
            return await _teamrepostory.GeAllAsync();
        }

        public async Task<Team> GetByIdAsync(int id)
        {
            return await _teamrepostory.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Team team)
        {
            var existEntity = await _teamrepostory.GetByIdAsync(team.Id);

            if (_teamrepostory.Table.Any(x => x.Name == team.Name && existEntity.Id != team.Id))
                throw new NullReferenceException();

            existEntity.Name = team.Name;
            await _teamrepostory.CommitAsync();
        }
    }
}
