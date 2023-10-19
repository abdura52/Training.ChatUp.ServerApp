namespace Traning.ChatUp.App.Backend.Domain.Common;

public abstract class AuditableEntity : Entity, IAuditableEntity
{
    public DateTimeOffset CreatedDate { get; set; }
    
    public DateTimeOffset? ModifiedDate { get; set; }
}
