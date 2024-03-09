using Microsoft.AspNetCore.Identity;

namespace UdemyCleanArchitecture.Domain.Entities;
public sealed class AppRole : IdentityRole<string>
{
    public AppRole()
    {
        Id = Guid.NewGuid().ToString();
    }
}
