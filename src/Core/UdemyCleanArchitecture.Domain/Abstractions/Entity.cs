namespace UdemyCleanArchitecture.Domain.Abstractions;
public abstract class Entity<Type>
{
    public Entity()
    {
        if (typeof(Type) == typeof(Guid))
        {
            Id = (Type)(object)Guid.NewGuid();
        }

        if (typeof(Type) == typeof(string))
        {
            Id = (Type)(object)Guid.NewGuid();
        }

        CreatedDate = DateTime.Now;
    }

    public Type Id { get; private set; }
    public Guid CreatedbyId { get; set; }
    public DateTime CreatedDate { get; private set; }
    public Guid? UpdatedById { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public Guid? DeletedById { get; set; }
    public DateTime? DeletedDate { get; set; }
    public bool IsDeleted { get; set; } = false;
}
