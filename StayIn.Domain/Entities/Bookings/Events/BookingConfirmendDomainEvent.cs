using StayIn.Domain.Abstractions;

namespace StayIn.Domain.Entities.Bookings.Events;
public record BookingConfirmedDomainEvent(Guid bookingId) : IDomainEvent;
