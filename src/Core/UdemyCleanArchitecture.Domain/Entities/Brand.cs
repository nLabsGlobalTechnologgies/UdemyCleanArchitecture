using UdemyCleanArchitecture.Domain.Abstractions;

namespace UdemyCleanArchitecture.Domain.Entities;
public sealed class Brand : Entity
{
    public string Name { get; set; } = string.Empty;
}
