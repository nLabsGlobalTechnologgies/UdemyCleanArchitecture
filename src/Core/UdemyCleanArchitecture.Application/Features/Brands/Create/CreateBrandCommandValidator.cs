using FluentValidation;

namespace UdemyCleanArchitecture.Application.Features.Brands.Create;
public sealed class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommand>
{
    public CreateBrandCommandValidator()
    {
        RuleFor(b => b.Name).NotEmpty().NotNull().WithMessage("Marka boş olamaz!");
        RuleFor(b => b.Name).MinimumLength(3).WithMessage("Marka en az 3 karakter olmalıdır!");
    }
}
