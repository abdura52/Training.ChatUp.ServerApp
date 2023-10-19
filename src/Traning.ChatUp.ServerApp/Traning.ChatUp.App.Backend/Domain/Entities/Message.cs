using Traning.ChatUp.App.Backend.Domain.Common;

namespace Traning.ChatUp.App.Backend.Domain.Entities;

public class Message : SoftDeletedEntity
{
    public string Content { get; set; } = string.Empty;

    public Guid UserId { get; set; }

    public Guid ChatId { get; set; }
}
