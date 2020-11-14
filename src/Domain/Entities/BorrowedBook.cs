namespace CleanArchitecture.Domain.Entities
{
	

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @EqualsAndHashCode public class BorrowedBook implements Book
	public class BorrowedBook : Book
	{

		private long? bookId;
		private long? userId;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @EqualsAndHashCode.Exclude private java.time.System.DateTime borrowedDate;
		private System.DateTime borrowedDate;

		public BorrowedBook(long? bookId, long? userId)
		{
			this.bookId = bookId;
			this.userId = userId;
			this.borrowedDate = System.DateTime.Now;
		}

		public BorrowedBook(long? bookId, long? userId, System.DateTime borrowedDate)
		{
			this.bookId = bookId;
			this.userId = userId;
			this.borrowedDate = borrowedDate;
		}

		public virtual long? IdAsLong
		{
			get
			{
				return bookId;
			}
		}

		public virtual long? AssignedUserIdAsLong
		{
			get
			{
				return userId;
			}
		}

		public virtual System.DateTime BorrowedDateAsSystemInstant
		{
			get
			{
				return borrowedDate;
			}
		}
	}

}
