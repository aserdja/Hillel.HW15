using HW15.DAL.Data;
using HW15.DAL.Interfaces;
using HW15.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HW15.DAL.Repositories
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly BooksDbContext _context;
		private readonly DbSet<T> _dbSet;

		public Repository(BooksDbContext context)
		{
			_context = context;
			_dbSet = _context.Set<T>();
		}

		public void Add(T entity)
		{
			_dbSet.Add(entity);
		}

		public void Delete(T entity)
		{
			_dbSet.Remove(entity);
		}

		public async Task<IEnumerable<T>> GetAll()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<T> GetById(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public void Update(T entity)
		{
			_dbSet.Update(entity);
		}
	}
}
