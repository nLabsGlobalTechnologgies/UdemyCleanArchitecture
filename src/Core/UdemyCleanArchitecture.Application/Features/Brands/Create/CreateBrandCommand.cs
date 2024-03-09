using MediatR;
using UdemyCleanArchitecture.Application.Result;

namespace UdemyCleanArchitecture.Application.Features.Brands.Create;
public sealed record CreateBrandCommand(
    string Createdby,
    string Name
) : IRequest<Result<string>>;
