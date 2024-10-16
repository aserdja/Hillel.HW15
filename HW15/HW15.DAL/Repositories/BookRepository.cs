using HW15.DAL.Data;
using HW15.DAL.Interfaces;
using HW15.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HW15.DAL.Repositories
{
	public class BookRepository : Repository<Book>, IBookRepository
	{
		private readonly BooksDbContext _context;

		public BookRepository(BooksDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Book>> GetAllByAuthor(Author author)
		{
			return await _context.Books.Where(b => b.Author == author).ToListAsync();
		}

		public async Task<IEnumerable<Book>> GetAllByGenre(Genre genre)
		{
			return await _context.Books.Where(b => b.Genre == genre).ToListAsync();
		}
	}
}
