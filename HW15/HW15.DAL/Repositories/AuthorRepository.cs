using HW15.DAL.Data;
using HW15.DAL.Interfaces;
using HW15.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HW15.DAL.Repositories
{
	public class AuthorRepository : Repository<Author>, IAuthorRepository
	{
		private readonly BooksDbContext _context;

		public AuthorRepository(BooksDbContext context) : base(context) 
		{
			_context = context;
		}

		public async Task<Author> GetByName(string name)
		{
			return await _context.Authors.Where(a => a.Name == name).FirstAsync();
		}
	}
}
