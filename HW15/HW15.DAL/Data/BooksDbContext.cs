using HW15.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HW15.DAL.Data
{
	public class BooksDbContext : DbContext
	{
		public virtual DbSet<Book> Books { get; set; }
		public virtual DbSet<Author> Authors { get; set; }
		public virtual DbSet<Genre> Genres { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Book>()
				.HasKey(x => x.Id);
			modelBuilder.Entity<Author>()
				.HasKey(x => x.Id);
			modelBuilder.Entity<Genre>()
				.HasKey(x => x.Id);

			modelBuilder.Entity<Book>()
				.Property(b => b.Title)
				.IsRequired();

			modelBuilder.Entity<Book>()
				.Property(b => b.PublishedYear)
				.IsRequired();

			modelBuilder.Entity<Author>()
				.Property(a => a.Name)
				.IsRequired();

			modelBuilder.Entity<Author>()
				.Property(a => a.DateOfBirth)
				.IsRequired();

			modelBuilder.Entity<Genre>()
				.Property(g => g.Name)
				.IsRequired();

			
			modelBuilder.Entity<Author>()
				.HasMany<Book>(a => a.Books)
				.WithOne(b => b.Author)
				.HasForeignKey(b => b.AuthorId);

			modelBuilder.Entity<Genre>()
				.HasMany<Book>(g => g.Books)
				.WithOne(b => b.Genre)
				.HasForeignKey(g => g.GenreId);
		}
	}
}
