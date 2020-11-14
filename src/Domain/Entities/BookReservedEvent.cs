namespace CleanArchitecture.Domain.Entities
{

	public class BookReservedEvent
	{

		private readonly ReservationId reservationId;
		private readonly long? userId;
		private readonly ReservedBook reservedBook;
		private readonly System.DateTime timestamp;

		public BookReservedEvent(ReservationDetails reservationDetails)
		{
			this.reservationId = reservationDetails.ReservationId;
			this.userId = reservationDetails.ReservedBook.AssignedUserIdAsLong;
			this.reservedBook = reservationDetails.ReservedBook;
			timestamp = System.DateTime.Now;
		}

		public virtual long? ReservationIdAsLong
		{
			get
			{
				return reservationId.IdAsLong;
			}
		}

		public virtual long? UserIdAsLong
		{
			get
			{
				return userId;
			}
		}

		public virtual long? BookIdAsLong
		{
			get
			{
				return reservedBook.IdAsLong;
			}
		}

		public virtual string EventTimeStampAsString
		{
			get
			{
				return timestamp.ToString();
			}
		}

	}

}