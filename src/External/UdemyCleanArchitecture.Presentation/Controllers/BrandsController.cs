using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCleanArchitecture.Application.Features.Brands.Create;
using UdemyCleanArchitecture.Application.Features.Brands.Queries;
using UdemyCleanArchitecture.Presentation.Abstraction;

namespace UdemyCleanArchitecture.Presentation.Controllers;
internal class BrandsController : ApiController
{
    public BrandsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllBrandQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateBrandCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
