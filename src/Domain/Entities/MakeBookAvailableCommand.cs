namespace CleanArchitecture.Domain.Entities
{
	public class MakeBookAvailableCommand
	{
		private long? bookId;

        public long? BookId { get => bookId; set => bookId = value; }
    }

}