using CleanArchitecture.Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class GiveBackBookCommandHandler : IRequestHandler<GiveBackBookCommand>
    {
        private readonly IApplicationDbContext _dbContext;

        public GiveBackBookCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(GiveBackBookCommand request, CancellationToken cancellationToken)
        {
            var borrowedBook = await _dbContext.BorrowedBooks
                .FindAsync(new object[] { request.BookId }, cancellationToken: cancellationToken);

            _dbContext.BorrowedBooks.Remove(borrowedBook);

            await _dbContext.SaveChangesAsync(cancellationToken);            

            return Unit.Value;
        }
    }
}