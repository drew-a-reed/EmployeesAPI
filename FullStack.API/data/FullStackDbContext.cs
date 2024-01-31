using FullStack.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.data
{
	public class FullStackDbContext: DbContext
	{

		public FullStackDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Employee> Employees { get; set; }
	}
}
