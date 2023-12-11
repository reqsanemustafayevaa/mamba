using examtask.MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examtask.core.Repostories.Interfaces
{
    public interface IGenericRepostory<TEntity>
                        where TEntity : BaseEntity, new()
    {
        public DbSet<TEntity> Table { get; }

        Task CreateAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GeAllAsync();

        void Delete(TEntity entity);
        Task<int> CommitAsync();
    }
}
