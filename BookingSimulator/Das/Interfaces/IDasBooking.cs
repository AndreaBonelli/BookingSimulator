﻿using BookingSimulator.BusinessLayers.Models.Bookings;

namespace BookingSimulator.Das.Interfaces
{
    public interface IDasBooking
    {
        public Booking Add(Booking booking);
        public Booking Update(Booking booking);
    }
}
