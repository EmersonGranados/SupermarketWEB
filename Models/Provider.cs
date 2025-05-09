﻿namespace SupermarketWEB.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
