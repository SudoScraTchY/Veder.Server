namespace Domain.Common.Interfaces;

public interface IDomainEvent
{
    DateTime OccurredAt { get; } 
}