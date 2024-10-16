using HW15.DAL.Models;

namespace HW15.DAL.Interfaces
{
	public interface IUnitOfWork
	{
		IAuthorRepository Authors { get; }
		IBookRepository Books { get; }
		IRepository<Genre> Genres { get; }
		Task Commit();
	}
}
