namespace CleanArchitecture.Domain.Entities
{
	public class OverdueReservation
	{
		private long? reservationId;
		private long? bookIdentification;

        public long? ReservationId { get => reservationId; set => reservationId = value; }
        public long? BookIdentification { get => bookIdentification; set => bookIdentification = value; }
    }

}