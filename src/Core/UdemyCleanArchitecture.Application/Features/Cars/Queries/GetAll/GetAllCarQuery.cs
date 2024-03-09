using MediatR;
using UdemyCleanArchitecture.Application.Pagination;
using UdemyCleanArchitecture.Domain.Entities;

namespace UdemyCleanArchitecture.Application.Features.Cars.Queries.GetAll;
public sealed record GetAllCarQuery(
    int PageNumber = 1,
    int PageSize = 10,
    string Search = ""
) : IRequest<PaginationResult<Car>>;
