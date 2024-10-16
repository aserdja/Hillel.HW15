namespace HW15.DAL.Interfaces
{
	public interface IRepository<T>
	{
		Task<T> GetById(int id);
		Task<IEnumerable<T>> GetAll();
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}
