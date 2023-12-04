using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateServiceCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.BlogId);
            values.AuthorID = request.AuthorID;
            values.CreatedDate = request.CreatedDate;
            values.Title = request.Title;
            values.CategoryId = request.CategoryId;
            values.CoverImageUrl = request.CoverImageUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
