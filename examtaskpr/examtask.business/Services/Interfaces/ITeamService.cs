﻿using examtask.MVC.Models;
using Humanizer.Localisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examtask.business.Services.Interfaces
{
    public interface ITeamService
    {
        Task CreateAsync(Team entity);
        Task Delete(int id);
        Task<Team> GetByIdAsync(int id);
        Task<List<Team >> GetAllAsync();
        Task UpdateAsync(Team genre);
    }
}
