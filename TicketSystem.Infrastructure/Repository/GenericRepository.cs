using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicktingSystem.Domain.Models;
using TicktingSystem.Domain.Repository;

namespace TicketSystem.Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T entity)             
        {
            await _context.Set<T>().AddAsync(entity);   
            await _context.SaveChangesAsync();          
            return entity;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var result =  await _context.Set<T>().FindAsync(id);
            if (result != null)
            {
                _context.Set<T>().Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        

        public async Task<List<T>> GetAll()
        {
            var ticket = await _context.Set<T>().ToListAsync();
            return ticket;
        }

      

        public async Task<T> GetByIdAsync(int id)
        {
            var ticket = await _context.Set<T>().FindAsync(id);

            return ticket;
        }

        public async Task<T> Update(T entity)
        {
             _context.Set<T>().Update(entity);
         
            
            await _context.SaveChangesAsync();

            return entity;

        }

    }
}
