using System;

namespace CleanArchitecture.Domain.Exceptions
{
	public class ActiveUserNotFoundException : Exception
	{
		public ActiveUserNotFoundException(long? bookId) : base("There is no active user with an ID: " + bookId)
		{
		}
	}

}