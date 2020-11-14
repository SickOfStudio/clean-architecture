using System;

namespace CleanArchitecture.Domain.Exceptions
{
	public class ReservedBookNotFoundException : Exception
	{
		public ReservedBookNotFoundException(long? bookId) : base("There is no reserved book with an ID: " + bookId)
		{
		}
	}

}