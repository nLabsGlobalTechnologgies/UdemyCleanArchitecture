using MediatR;
using UdemyCleanArchitecture.Application.Pagination;
using UdemyCleanArchitecture.Domain.Entities;

namespace UdemyCleanArchitecture.Application.Features.Brands.Queries;
public sealed record GetAllBrandQuery(
    int PageNumber = 1,
    int PageSize = 10,
    string Search = ""
) : IRequest<PaginationResult<Brand>>;
