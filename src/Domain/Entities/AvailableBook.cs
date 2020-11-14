namespace CleanArchitecture.Domain.Entities
{
    
	public class AvailableBook : Book
	{

		private readonly long? id;

		public AvailableBook(long? id)
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