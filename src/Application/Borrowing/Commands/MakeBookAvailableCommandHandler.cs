using CleanArchitecture.Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class MakeBookAvailableCommandHandler : IRequestHandler<MakeBookAvailableCommand>
    {
        private readonly IApplicationDbContext _dbContext;

        public MakeBookAvailableCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(MakeBookAvailableCommand request, CancellationToken cancellationToken)
        {
            AvailableBook entity = new AvailableBook() { Id = request.BookId};
            await _dbContext.AvailableBooks.AddAsync(entity, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}