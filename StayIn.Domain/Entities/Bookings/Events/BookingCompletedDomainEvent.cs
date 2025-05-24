using StayIn.Domain.Abstractions;

namespace StayIn.Domain.Entities.Bookings.Events;
public record BookinCompletedDomainEvent(Guid bookingId) : IDomainEvent;
