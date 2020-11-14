using System;

namespace CleanArchitecture.Domain.Entities
{
	public class BorrowedBook : IBook
	{
		public BorrowedBook()
		{
			BorrowedDateAsSystemInstant = DateTime.Now;
		}

		public virtual long Id { get; set; }
		
		public virtual long UserId { get; set; }

		public virtual DateTime BorrowedDateAsSystemInstant { get; set; }
	}

}
