namespace Domain.Common.Concrete;

public abstract class AggregateRoot<TId> : Entity<TId> 
    where TId : notnull
{
}