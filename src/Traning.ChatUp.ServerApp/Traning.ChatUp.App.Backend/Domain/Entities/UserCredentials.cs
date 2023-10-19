using Traning.ChatUp.App.Backend.Domain.Common;

namespace Traning.ChatUp.App.Backend.Domain.Entities;

public class UserCredentials : SoftDeletedEntity
{
    public string PasswordHash { get; set; } = string.Empty;

    public Guid UserId { get; set; }
}
