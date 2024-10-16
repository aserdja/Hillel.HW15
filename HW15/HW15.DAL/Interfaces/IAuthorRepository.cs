using HW15.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.DAL.Interfaces
{
	public interface IAuthorRepository : IRepository<Author>
	{
		Task<Author> GetByName(string name);
	}
}
