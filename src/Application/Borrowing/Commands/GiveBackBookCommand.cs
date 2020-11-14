using MediatR;
using System.Linq;

namespace CleanArchitecture.Domain.Entities
{

    public class GiveBackBookCommand : IRequest
	{		
        public long BookId { get ; set; }
        public long? UserId { get; set ; }
    }
}