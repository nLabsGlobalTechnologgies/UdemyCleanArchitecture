using Microsoft.AspNetCore.Mvc;
using UdemyCleanArchitecture.Presentation.Abstraction;

namespace UdemyCleanArchitecture.Presentation.Controllers;

public sealed class ValuesController : ApiController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return NoContent();
    }
}
