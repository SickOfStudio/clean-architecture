using System;

namespace CleanArchitecture.Domain.Entities
{
	public class ReservedBook : IBook
	{
		public ReservedBook()
		{
			ReservedDate = DateTime.Now;
		}

		public long Id { get; set; }

		public long AssignedUserId { get; set; }

		public DateTime ReservedDate { get; set; }
	}
}