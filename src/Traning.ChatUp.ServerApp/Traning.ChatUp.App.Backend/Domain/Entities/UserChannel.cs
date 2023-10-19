using Traning.ChatUp.App.Backend.Domain.Common;

namespace Traning.ChatUp.App.Backend.Domain.Entities;

public class UserChannel : SoftDeletedEntity
{
    public Guid UserId { get; set; }

    public Guid ChannelId { get; set; }
}
