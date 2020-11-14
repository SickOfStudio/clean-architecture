using MediatR;

namespace CleanArchitecture.Domain.Entities
{
    public class MakeBookAvailableCommand : IRequest
	{
        public long BookId { get; set ; }
    }
}