namespace HW15.DAL.Models
{
	public class Author
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public DateOnly DateOfBirth { get; set; }

		public ICollection<Book>? Books { get; set; }
	}
}