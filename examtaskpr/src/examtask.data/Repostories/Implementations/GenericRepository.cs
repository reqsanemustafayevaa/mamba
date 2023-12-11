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
    public class GenericRepository<TEntity> : IGenericRepostory<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context=context;   
        }
        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();  
        }

        public async Task CreateAsync(TEntity entity)
        {
            await Table.AddAsync(entity);
           
        }

        public void Delete(TEntity entity)
        {
            Table.Remove(entity);
        }

        public async Task<List<TEntity>> GeAllAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await Table.FirstOrDefaultAsync(x => x.Id == id);



        }

        
    }
}
