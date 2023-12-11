using examtask.core.Repostories.Interfaces;
using examtask.data.DAL;
using examtask.MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examtask.data.Repostories.Implementations
{
    public class TeamRepostory : GenericRepository<Team>, ITeamRepostory
    {
        public TeamRepostory(AppDbContext context) : base(context)
        {
        }
    }
}
