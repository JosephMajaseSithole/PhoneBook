using Microsoft.EntityFrameworkCore;
using PhoneBook.Core.Models;

namespace PhoneBook.DbLayer
{
	public class PhoneBookDBContext : DbContext
	{
		public PhoneBookDBContext(DbContextOptions<PhoneBookDBContext> options)
				: base(options)
		{ }

		public DbSet<Entry> PhoneBookEntries { get; set; }

	}
}
