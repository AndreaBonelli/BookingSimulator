﻿namespace BookingSimulator.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public string? Content { get; set; }
        public int IdHotel { get; set; }
    }
}