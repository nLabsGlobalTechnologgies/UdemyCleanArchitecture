using MediatR;
using UdemyCleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using UdemyCleanArchitecture.Application.Result;
using UdemyCleanArchitecture.Application.Services;

namespace UdemyCleanArchitecture.Application.Features.CarFeatures.Commands.CreateCars;

public sealed class CreateCarCommandHandler(ICarService carService) : IRequestHandler<CreateCarCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateCarCommand request, CancellationToken cancellationToken)
    {
        await carService.CreateAsync(request, cancellationToken);

        return Result<string>.Succeed("Araç başarıyla kaydedildi");
    }
}
