using HW15.DAL.Interfaces;
using HW15.DAL.Models;

namespace HW15.BL.Services
{
	public class LibraryService(IUnitOfWork unitOfWork)
	{
		private readonly IUnitOfWork _unitOfWork = unitOfWork;

		public async Task AddNewBook(Book book)
		{
			_unitOfWork.Books.Add(book);
			await _unitOfWork.Commit();
		}

		public async Task UpdateBookInfo(Book book)
		{
			_unitOfWork.Books.Update(book);
			await _unitOfWork.Commit();
		}

		public async Task DeleteBook(Book book)
		{
			_unitOfWork.Books.Delete(book);
			await _unitOfWork.Commit();
		}

		public async Task<IEnumerable<Book>> GetAllBooks()
		{
			return await _unitOfWork.Books.GetAll();
		}

		public async Task<IEnumerable<Book>> GetAllBooksByAuthor(Author author)
		{
			return await _unitOfWork.Books.GetAllByAuthor(author);
		}

		public async Task<IEnumerable<Book>> GetAllBooksByGenre(Genre genre)
		{
			return await _unitOfWork.Books.GetAllByGenre(genre);
		}
	}
}
