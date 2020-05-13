using Microsoft.AspNetCore.Mvc;
using PhoneBook.Core.Interfaces;
using PhoneBook.Core.Models;
using PhoneBook.Repository.Repositories;
using System;
using System.Collections.Generic;

namespace PhoneBook.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class PhoneBookController : ControllerBase
	{
		private readonly IPhoneBookRepository _phoneBook;

		public PhoneBookController(IPhoneBookRepository phoneBook)
		{
			_phoneBook = phoneBook;
		}

		[HttpGet]
		public IActionResult GetPhoneBookEntries(string entryName)
		{
			var phoneBookEntries = new List<Entry>();

			try
			{
				phoneBookEntries = _phoneBook.GetEntries(entryName);
			}
			catch (Exception ex)
			{
				throw ex;
			}

			return Ok(phoneBookEntries);
		}

		[HttpPost]
		public IActionResult AddPhoneBookEntry(Entry phoneBookEntry)
		{
			var _phoneBookEntry = new Entry();

			try
			{
				_phoneBookEntry = _phoneBook.AddPhoneBookEntry(phoneBookEntry);
			}
			catch (Exception ex)
			{
				throw ex;
			}

			return Ok(_phoneBookEntry);
		}
	}
}
