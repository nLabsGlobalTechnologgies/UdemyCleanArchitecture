using UdemyCleanArchitecture.Domain.Abstractions;

namespace UdemyCleanArchitecture.Domain.Entities;
public class Car : Entity
{
    public string Name { get; set; } = string.Empty;
    public Guid? BrandId { get; set; }
    public Brand? Brand { get; set; }
    public Guid? ModelId { get; set; }
    public Model? Model { get; set; }
    public int EnginePower { get; set; } = 1;
}
