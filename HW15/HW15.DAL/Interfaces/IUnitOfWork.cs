using HW15.DAL.Models;

namespace HW15.DAL.Interfaces
{
	public interface IUnitOfWork
	{
		IRepository<Author> Authors { get; }
		IRepository<Book> Books { get; }
		IRepository<Genre> Genres { get; }
		Task Commit();
	}
}
