using CarBook.Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAdressQuery : IRequest<List<GetFooterAddresQueryResult>>
    {
    }
}
