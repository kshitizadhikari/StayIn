using StayIn.Domain.Abstractions;

namespace StayIn.Domain.Entities.Bookings.Events;
public record BookingCancelledDomainEvent(Guid bookingId) : IDomainEvent;
