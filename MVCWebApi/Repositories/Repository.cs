﻿using Microsoft.EntityFrameworkCore;
using MVCWebApi.DataAccessLayer;
using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.Repositories
{
    public class Repository<T> : ICRUD<T>
                where T : EntityModel
    {
        private readonly LibraryContext _context;

        public Repository(LibraryContext Context)
        {
            _context = Context;
        }
        
        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetPage(int pageIndex, int pageSize)
        {
            return await _context.Set<T>().Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task Create(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }
        
        public async Task Update(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
        
        public async Task<T> Read(int? id)
        {
            return await _context.Set<T>()
                .SingleOrDefaultAsync(m => m.Id == id);
        }
        
        public async Task Delete(int? id)
        {
            var entity = await GetById(id);
            _context.Set<T>()
            .Remove(entity);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemoveByValue(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
        
        public async Task<T> GetById(int? id)
        {
            return await _context.Set<T>()
                        .AsNoTracking()
                        .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
