using Domain.Common.Interfaces;

namespace Domain.Common.Concrete;

public abstract class SoftDeletableAggregateRoot<TId> : AuditableAggregateRoot<TId>, ISoftDelete 
    where TId : notnull
{
    public bool IsDeleted { get; private set; }
    public DateTime? DeletedAt { get; private set; }
    
    public void SoftDelete()
    {
        IsDeleted = true;
        DeletedAt = DateTime.UtcNow;
    }
}