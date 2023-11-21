using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;

        public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {


            var values = await _repository.GetByIdAsync(request.Id);
            values.Name = request.Name;
            await _repository.UpdateAsync(values);

        }
    }
}
