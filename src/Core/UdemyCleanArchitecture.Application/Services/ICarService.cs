using UdemyCleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using UdemyCleanArchitecture.Application.Features.Cars.Queries.GetAll;
using UdemyCleanArchitecture.Application.Pagination;
using UdemyCleanArchitecture.Application.Result;
using UdemyCleanArchitecture.Domain.Entities;

namespace UdemyCleanArchitecture.Application.Services;
public interface ICarService
{
    Task<Result<string>> CreateAsync(CreateCarCommand request, CancellationToken cancellationToken);
    Task<PaginationResult<Car>> GetAllAsync(GetAllCarQuery request, CancellationToken cancellationToken);
}
