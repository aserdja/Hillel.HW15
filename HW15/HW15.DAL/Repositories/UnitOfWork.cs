using HW15.DAL.Data;
using HW15.DAL.Interfaces;
using HW15.DAL.Models;

namespace HW15.DAL.Repositories
{
	public class UnitOfWork(BooksDbContext context) : IUnitOfWork
	{
		private readonly BooksDbContext _context = context;
		private Repository<Author>? _authors;
		private Repository<Book>? _books;
		private Repository<Genre>? _genres;

		public IRepository<Author> Authors
		{
			get
			{
				return _authors ?? (_authors = new Repository<Author>(_context));
			}
		}
		public IRepository<Book> Books
		{
			get
			{
				return _books ?? (_books = new Repository<Book>(_context));
			}
		}
		public IRepository<Genre> Genres
		{
			get
			{
				return _genres ?? (_genres = new Repository<Genre>(_context));
			}
		}

		public async Task Commit()
		{
			await _context.SaveChangesAsync();
		}
	}
}
