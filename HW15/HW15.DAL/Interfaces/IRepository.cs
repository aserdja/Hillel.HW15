namespace HW15.DAL.Interfaces
{
	public interface IRepository<T>
	{
		Task<T> GetById(int id);
		Task<IEnumerable<T>> GetAll();
		Task Add(T entity);
		Task Update(T entity);
		Task Delete(T entity);
	}
}
