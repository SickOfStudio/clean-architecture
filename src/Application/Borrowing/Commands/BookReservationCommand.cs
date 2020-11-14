using MediatR;

namespace CleanArchitecture.Domain.Entities
{

    public class BookReservationCommand : IRequest<long>
	{
		public long bookId;
		public long userId;
	}
}