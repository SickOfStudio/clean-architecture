using System;

namespace CleanArchitecture.Domain.Exceptions
{
	public class TooManyBooksAssignedToUserException : Exception
	{
		public TooManyBooksAssignedToUserException(long? userId) : base("You can't assign another book to user account: " + userId + ". Reason: Too many books already assigned.")
		{
		}
	}

}