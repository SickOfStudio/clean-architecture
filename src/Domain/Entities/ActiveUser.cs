using CleanArchitecture.Domain.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Domain.Entities
{
	using TooManyBooksAssignedToUserException = TooManyBooksAssignedToUserException;
	

	public class ActiveUser
	{

		private readonly long? id;
		private readonly IList<ReservedBook> reservedBooks;
		private readonly IList<BorrowedBook> borrowedBooks;

		public ActiveUser(long? id, IList<ReservedBook> reservedBooks, IList<BorrowedBook> borrowedBooks)
		{
			this.id = id;
			this.reservedBooks = reservedBooks;
			this.borrowedBooks = borrowedBooks;
		}

		public virtual ReservedBook reserve(AvailableBook availableBook)
		{
			if (hasUserNotReachedLimitOfBooks())
			{
				ReservedBook reservedBook = new ReservedBook(availableBook.IdAsLong, id);
				reservedBooks.Add(reservedBook);
				return reservedBook;
			}
			else
			{
				throw new TooManyBooksAssignedToUserException(id);
			}
		}

		public virtual BorrowedBook borrow(ReservedBook reservedBook)
		{
			if (hasUserNotReachedLimitOfBooks())
			{
				BorrowedBook borrowedBook = new BorrowedBook(reservedBook.IdAsLong, id);
				borrowedBooks.Add(borrowedBook);
				return borrowedBook;
			}
			else
			{
				throw new TooManyBooksAssignedToUserException(id);
			}
		}

		public virtual AvailableBook giveBack(BorrowedBook borrowedBook)
		{
            
            bool isBookRemovedFromUserAccount = borrowedBooks.Any(book => book.AssignedUserIdAsLong == borrowedBook.AssignedUserIdAsLong);
			
			if (isBookRemovedFromUserAccount)
			{
				return new AvailableBook(borrowedBook.IdAsLong);
			}
			else
			{
				throw new System.ArgumentException("User with an id: " + id + " didn't borrow book with an id: " + borrowedBook.IdAsLong);
			}
		}

		public virtual long? IdAsLong
		{
			get
			{
				return id;
			}
		}

		public virtual IList<ReservedBook> ReservedBookList
		{
			get
			{
				return reservedBooks;
			}
		}

		public virtual IList<BorrowedBook> BorrowedBookList
		{
			get
			{
				return borrowedBooks;
			}
		}

		private bool hasUserNotReachedLimitOfBooks()
		{
			return reservedBooks.Count + borrowedBooks.Count < 3;
		}
	}

}