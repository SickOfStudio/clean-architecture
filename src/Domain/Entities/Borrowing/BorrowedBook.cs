using System;

namespace CleanArchitecture.Domain.Entities
{
	public class BorrowedBook : IBook
	{
		public BorrowedBook(long? bookId, long? userId)
		{
			Id = bookId;
			AssignedUserId = userId;
			BorrowedDateAsSystemInstant = System.DateTime.Now;
		}

		public BorrowedBook(long? bookId, long? userId, System.DateTime borrowedDate)
		{
			Id = bookId;
			AssignedUserId = userId;
			BorrowedDateAsSystemInstant = borrowedDate;
		}

		public virtual long? Id { get; set; }
		
		public virtual long? AssignedUserId { get; set; }

		public virtual DateTime BorrowedDateAsSystemInstant { get; set; }
	}

}
