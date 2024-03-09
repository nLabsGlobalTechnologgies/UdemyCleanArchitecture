using UdemyCleanArchitecture.Domain.Abstractions;

namespace UdemyCleanArchitecture.Domain.Entities;
public sealed class Model : Entity
{
    public string Year { get; set; } = string.Empty;
    public ICollection<Brand>? Brands { get; set; }
}
