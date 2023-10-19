using Traning.ChatUp.App.Backend.Domain.Common;
using Traning.ChatUp.App.Backend.Domain.Enums;

namespace Traning.ChatUp.App.Backend.Domain.Entities;

public class Channel : SoftDeletedEntity
{
    public string Name { get; set; } = string.Empty;

    public string UserName { get; set; } = string.Empty;

    public string? Description { get; set; }

    public ChatType Type { get; set; }

    public Guid OwnerId { get; set; }
}
