using StayIn.Domain.Abstractions;

namespace StayIn.Domain.Entities.Bookings.Events;
public record BookingRejectedDomainEvent(Guid bookingId) : IDomainEvent;
