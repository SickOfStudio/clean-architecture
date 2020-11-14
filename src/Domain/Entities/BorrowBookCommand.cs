﻿namespace CleanArchitecture.Domain.Entities
{	
	public class BorrowBookCommand
	{
		private long? bookId;
		private long? userId;

        public long? BookId { get => bookId; set => bookId = value; }
        public long? UserId { get => userId; set => userId = value; }
    }

}