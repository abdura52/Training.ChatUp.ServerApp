using Traning.ChatUp.App.Backend.Domain.Common;

namespace Traning.ChatUp.App.Backend.Domain.Entities;

public class Chat : SoftDeletedEntity
{
    public Guid FirstUser { get; set; }

    public Guid SecondUser { get; set; }
}
