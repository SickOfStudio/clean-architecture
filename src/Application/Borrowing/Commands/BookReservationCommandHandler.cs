using CleanArchitecture.Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class BookReservationCommandHandler : IRequestHandler<BookReservationCommand, long>
    {
        private readonly IApplicationDbContext _dbContext;

        public BookReservationCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<long> Handle(BookReservationCommand request, CancellationToken cancellationToken)
        {
            ReservedBook entity = new ReservedBook
            {                
                Id = request.bookId,
                AssignedUserId = request.userId
            };

            await _dbContext.ReservedBookss.AddAsync(entity, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}