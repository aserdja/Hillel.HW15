using HW15.DAL.Models;

namespace HW15.DAL.Interfaces
{
	public interface IBookRepository : IRepository<Book>
	{
		Task<IEnumerable<Book>> GetAllByAuthor(Author author);
		Task<IEnumerable<Book>> GetAllByGenre(Genre genre);
	}
}
