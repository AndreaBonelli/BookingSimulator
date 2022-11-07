﻿namespace BookingSimulator.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}

