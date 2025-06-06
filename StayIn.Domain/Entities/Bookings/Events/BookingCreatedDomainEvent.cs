﻿using StayIn.Domain.Abstractions;

namespace StayIn.Domain.Entities.Bookings.Events;
public record BookingCreatedDomainEvent(Guid bookingId) : IDomainEvent;
