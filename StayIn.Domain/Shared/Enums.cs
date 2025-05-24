namespace StayIn.Domain.Shared;
public class Enums
{
    public enum BookingStatus
    {
        Reserved = 1,
        Confirmed = 2,
        Rejected = 3,
        Cancelled = 4,
        Completed = 5
    }
    public enum BookingErrors
    {
        NotPending = 1,
        NotReserved = 2,
        NotConfirmed = 3,
        AlreadyStarted = 4
    }
}
