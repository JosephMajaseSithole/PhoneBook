using PhoneBook.Core.Interfaces;
using PhoneBook.Core.Models;
using PhoneBook.DbLayer;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook.Repository.Repositories
{
	public class PhoneBookRepository : IPhoneBookRepository
	{
		private readonly PhoneBookDBContext _phoneBookContext;

		public PhoneBookRepository(PhoneBookDBContext phoneBookContext)
		{
			_phoneBookContext = phoneBookContext;
		}
		public Entry AddPhoneBookEntry(Entry phoneBookEntry)
		{
			_phoneBookContext.PhoneBookEntries.Add(phoneBookEntry);
			_phoneBookContext.SaveChanges();
			return phoneBookEntry;
		}

		public List<Entry> GetEntries(string entryName)
		{
			var entries = string.IsNullOrEmpty(entryName) ? _phoneBookContext.PhoneBookEntries : _phoneBookContext.PhoneBookEntries.Where(e => e.Name.Contains(entryName) || e.PhoneNumber.Contains(entryName));

			return entries.OrderBy(e => e.Name).ToList();
		}
	}
}
