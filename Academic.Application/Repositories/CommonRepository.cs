﻿using Academic.Application.Interfaces.IRepository;
using Academic.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Academic.Application.Repositories
{
    public class CommonRepository<T> : ICommonRepository<T>, IDisposable where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public CommonRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<int> CountAsync()
        {
            return await _dbSet.CountAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
