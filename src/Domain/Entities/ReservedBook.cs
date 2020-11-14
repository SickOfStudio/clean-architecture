namespace CleanArchitecture.Domain.Entities
{
	

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @EqualsAndHashCode public class ReservedBook implements Book
	public class ReservedBook : Book
	{

		private readonly long? bookId;
		private readonly long? userId;
		private readonly System.DateTime reservedDate;

		public ReservedBook(long? bookId, long? userId)
		{
			this.bookId = bookId;
			this.userId = userId;
			this.reservedDate = System.DateTime.Now;
		}

		public ReservedBook(long? bookId, long? userId, System.DateTime reservedDate)
		{
			this.bookId = bookId;
			this.userId = userId;
			this.reservedDate = reservedDate;
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

		public virtual System.DateTime ReservedDateAsSystemInstant
		{
			get
			{
				return reservedDate;
			}
		}
	}

}