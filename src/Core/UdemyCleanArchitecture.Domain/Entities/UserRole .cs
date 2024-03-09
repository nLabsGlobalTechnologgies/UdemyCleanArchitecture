using System.ComponentModel.DataAnnotations.Schema;
using UdemyCleanArchitecture.Domain.Abstractions;

namespace UdemyCleanArchitecture.Domain.Entities;
public sealed class UserRole : Entity
{

    [ForeignKey("AppUser")]
    public string UserId { get; set; } = string.Empty;
    public AppUser? User { get; set; }

    [ForeignKey("AppRole")]
    public string RoleId { get; set; } = string.Empty;
    public AppRole? Role { get; set; }
}
