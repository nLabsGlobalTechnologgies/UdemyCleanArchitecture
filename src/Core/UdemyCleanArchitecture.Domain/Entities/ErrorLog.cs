namespace UdemyCleanArchitecture.Domain.Entities;
public sealed class ErrorLog
{
    public string Id { get; private set; } = Guid.NewGuid().ToString();
    public string ErrorMessage { get; set; } = string.Empty;
    public string StackTrace { get; set; } = string.Empty;
    public string RequestPath { get; set; } = string.Empty;
    public string RequestMethod { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; } = DateTime.Now;
    public DateTime CreatedDate { get; private set; } = DateTime.Now.Date;
    public DateTime? UpdatedDate { get; set; }
}
