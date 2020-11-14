namespace CleanArchitecture.Domain.Entities
{
    
	public class AvailableBook : IBook
	{		
		public  long Id { get; set; }

        public long UserId { get; set; }
    }

}