using Traning.ChatUp.App.Backend.Domain.Common;

namespace Traning.ChatUp.App.Backend.Domain.Entities;

public class User : SoftDeletedEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string EmailAddress { get; set; } = string.Empty;

    public string ProfileImagePath { get; set; } = string.Empty;
}
