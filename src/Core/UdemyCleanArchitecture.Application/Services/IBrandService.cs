using UdemyCleanArchitecture.Application.Features.Brands.Create;
using UdemyCleanArchitecture.Application.Features.Brands.Queries;
using UdemyCleanArchitecture.Application.Pagination;
using UdemyCleanArchitecture.Application.Result;
using UdemyCleanArchitecture.Domain.Entities;

namespace UdemyCleanArchitecture.Application.Services;
public interface IBrandService
{
    Task<Result<string>> CreateAsync(CreateBrandCommand request, CancellationToken cancellationToken);
    Task<PaginationResult<Brand>> GetAllAsync(GetAllBrandQuery request, CancellationToken cancellationToken);
}
