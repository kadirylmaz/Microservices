using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationByBookingNumber(int bookingNumber)
        {
            return new ReservationDTO()
            {
                Id = new Random().Next(100),
                Amount = new Random().Next(10000),
                BookingDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(37),
                BookingNumber = bookingNumber
            };
        }
    }
}
