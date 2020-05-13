using PhoneBook.Core.Models;
using System.Collections.Generic;

namespace PhoneBook.Core.Interfaces
{
	public interface IPhoneBookRepository
	{
		Entry AddPhoneBookEntry(Entry phoneBookEntry);
		List<Entry> GetEntries(string entryName);
	}
}
