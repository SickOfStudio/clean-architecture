using System;

namespace CleanArchitecture.Domain.Exceptions
{
	public class BorrowedBookNotFoundException : Exception
	{
		public BorrowedBookNotFoundException(long? bookId) : base("There is no borrowed book with an ID: " + bookId)
		{
		}
	}

}