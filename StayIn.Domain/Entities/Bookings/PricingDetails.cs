using StayIn.Domain.Shared;

namespace StayIn.Domain.Entities.Booking;
public record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice);
