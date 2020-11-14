namespace CleanArchitecture.Domain.Entities
{
    public class ReservationDetails
	{

		private readonly ReservationId reservationId;
		private readonly ReservedBook reservedBook;

		public ReservationDetails(ReservationId reservationId, ReservedBook reservedBook)
		{
			this.reservationId = reservationId;
			this.reservedBook = reservedBook;
		}

        public ReservationId ReservationId => reservationId;

        public ReservedBook ReservedBook => reservedBook;
    }

}