using StayIn.Domain.Entities.Apartments;
using StayIn.Domain.Shared;

namespace StayIn.Domain.Entities.Booking;
public class PricingService
{
    public PricingDetails CalculatePrice(Apartment apartment, DateRange dateRange)
    {
        var currency = apartment.Price.Currency;
        Money priceForPeriod = new(
            apartment.Price.Amount * dateRange.LengthInDays,
            currency
            );

        decimal percentageUpCharge = 0;
        foreach (var amenity in apartment.Amenities)
        {
            percentageUpCharge += amenity switch
            {
                Amenity.GardenView or Amenity.MountainView => 0.05m,
                Amenity.AirConditioning => 0.2m,
                Amenity.Parking => 0.1m,
                _ => 0
            };
        }

        Money amenitiesUpCharge = Money.Zero();
        if (percentageUpCharge > 0)
        {
            amenitiesUpCharge = new(
                priceForPeriod.Amount * percentageUpCharge,
                currency);
        }

        var totalPrice = Money.Zero(currency);
        totalPrice = priceForPeriod + amenitiesUpCharge;

        if (!apartment.CleaningFee.IsZero())
        {
            totalPrice += apartment.CleaningFee;
        }

        return new PricingDetails(priceForPeriod, apartment.CleaningFee, amenitiesUpCharge, totalPrice);
    }
}
