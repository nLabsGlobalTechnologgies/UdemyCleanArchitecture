using MediatR;
using UdemyCleanArchitecture.Application.Result;
using UdemyCleanArchitecture.Application.Services;

namespace UdemyCleanArchitecture.Application.Features.Brands.Create;

public sealed class CreateBrandCommandHandler(IBrandService brandService) : IRequestHandler<CreateBrandCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
    {
        await brandService.CreateAsync(request, cancellationToken);

        return Result<string>.Succeed("Marka başarıyla kaydedildi");
    }
}
