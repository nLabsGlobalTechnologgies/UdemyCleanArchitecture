using MediatR;
using UdemyCleanArchitecture.Application.Result;

namespace UdemyCleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
public sealed record CreateCarCommand(
    string CreatedBy,
    string Name,
    Guid BrandId,
    Guid ModelId,
    int EnginePower
) : IRequest<Result<string>>;
