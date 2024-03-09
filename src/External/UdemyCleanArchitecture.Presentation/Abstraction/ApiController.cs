using Microsoft.AspNetCore.Mvc;

namespace UdemyCleanArchitecture.Presentation.Abstraction;

[Route("api/[controller]/[action]")]
[ApiController]
public abstract class ApiController : ControllerBase
{
}
