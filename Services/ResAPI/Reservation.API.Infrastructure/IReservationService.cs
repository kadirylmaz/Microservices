using Reservation.API.Models;

namespace Reservation.API.Infrastructure
{
    public interface IReservationService
    {
        ReservationDTO GetReservationByBookingNumber(int bookingNumber);
    }
}
