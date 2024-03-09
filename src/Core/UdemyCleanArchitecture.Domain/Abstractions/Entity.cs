namespace UdemyCleanArchitecture.Domain.Abstractions;
public abstract class Entity
{
    public string Id { get; private set; } = Guid.NewGuid().ToString();
    public string Createdby { get; set; } = string.Empty;
    public DateTime CreatedDate { get; private set; } = DateTime.Now;
    public string? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public string? DeletedBy { get; set; }
    public DateTime? DeletedDate { get; set; }
    public bool IsDeleted { get; set; } = false;
}
