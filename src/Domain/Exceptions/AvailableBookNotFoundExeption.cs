using System;

namespace CleanArchitecture.Domain.Exceptions
{
	public class AvailableBookNotFoundExeption : Exception
	{
		public AvailableBookNotFoundExeption(long? bookId) : base("There is no available book with an ID: " + bookId)
		{
		}
	}

}