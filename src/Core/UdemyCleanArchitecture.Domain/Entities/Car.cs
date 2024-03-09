using UdemyCleanArchitecture.Domain.Abstractions;

namespace UdemyCleanArchitecture.Domain.Entities;
public class Car : Entity<string>
{
    public string Name { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int EnginePower { get; set; } = 1;
}
