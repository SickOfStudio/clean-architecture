namespace CleanArchitecture.Domain.Entities
{    
    public class ReservationId
	{
		private readonly long? id;

		public ReservationId(long? id)
		{
			this.id = id;
		}

		public virtual long? IdAsLong
		{
			get
			{
				return id;
			}
		}
	}

}