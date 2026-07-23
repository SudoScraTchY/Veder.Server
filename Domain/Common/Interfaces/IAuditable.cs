namespace Domain.Common.Interfaces;

public interface IAuditable
{
    DateTime CreatedAt { get; }
    Guid CreatedBy { get; }
    DateTime? UpdatedAt { get; }
    Guid? UpdatedBy { get; }
}