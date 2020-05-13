using System.Collections.Generic;

namespace PhoneBook.Core.Models
{
	public class PhoneBook
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Entry> Entries { get; set; }
	}
}
