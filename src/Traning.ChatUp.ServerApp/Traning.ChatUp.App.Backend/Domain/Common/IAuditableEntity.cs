namespace Traning.ChatUp.App.Backend.Domain.Common;

public interface IAuditableEntity : IEntity
{
    DateTimeOffset CreatedDate { get; set; }
    
    DateTimeOffset? ModifiedDate { get; set; }
}
