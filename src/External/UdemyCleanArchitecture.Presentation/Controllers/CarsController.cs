using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using UdemyCleanArchitecture.Application.Features.Cars.Queries.GetAll;
using UdemyCleanArchitecture.Presentation.Abstraction;

namespace UdemyCleanArchitecture.Presentation.Controllers;
public sealed class CarsController : ApiController
{
    public CarsController(IMediator mediator) : base(mediator) { }

    [HttpPost]
    public async Task<IActionResult> Crate(CreateCarCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllCarQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
