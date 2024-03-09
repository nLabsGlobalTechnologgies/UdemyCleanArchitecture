using FluentValidation;
using UdemyCleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;

namespace UdemyCleanArchitecture.Application.Features.Cars.Commands.CreateCar;
public sealed class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
{
    public CreateCarCommandValidator()
    {
        RuleFor(r => r.Name).NotEmpty().NotNull().WithMessage("İsim boş olamaz!");
        RuleFor(r => r.Name).MinimumLength(3).WithMessage("İsim en az 3 karakter olmalıdır!");

        RuleFor(r => r.EnginePower).NotEmpty().NotNull().WithMessage("Motor gücü boş olamaz!");
        RuleFor(r => r.EnginePower).GreaterThan(0).WithMessage("Motor gücü 0 dan büyük olmalıdır!");
    }
}
