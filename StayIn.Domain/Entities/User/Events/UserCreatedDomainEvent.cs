using StayIn.Domain.Abstractions;

namespace StayIn.Domain.Entities.User.Events;
public record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
