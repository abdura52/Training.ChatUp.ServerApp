using Traning.ChatUp.App.Backend.Domain.Common;

namespace Traning.ChatUp.App.Backend.Domain.Entities;

public class UserGroup : SoftDeletedEntity
{
    public Guid UserId { get; set; }

    public Guid GroupId { get; set; }
}
