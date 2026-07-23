using Domain.Common.Interfaces;

namespace Domain.Common.Concrete;

public abstract record DomainEvent : IDomainEvent
{
    public DateTime OccurredAt { get; init; } = DateTime.UtcNow;
}