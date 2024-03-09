using MediatR;
using UdemyCleanArchitecture.Application.Pagination;
using UdemyCleanArchitecture.Application.Services;
using UdemyCleanArchitecture.Domain.Entities;

namespace UdemyCleanArchitecture.Application.Features.Cars.Queries.GetAll;
public sealed class GetAllCarQueryHandler : IRequestHandler<GetAllCarQuery, PaginationResult<Car>>
{
    private readonly ICarService _carService;

    public GetAllCarQueryHandler(ICarService carService)
    {
        _carService = carService;
    }

    public async Task<PaginationResult<Car>> Handle(GetAllCarQuery request, CancellationToken cancellationToken)
    {
        var cars = await _carService.GetAllAsync(request, cancellationToken).ConfigureAwait(false);
        return cars;
    }
}
