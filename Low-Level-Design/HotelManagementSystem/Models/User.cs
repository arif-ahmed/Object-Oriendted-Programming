﻿namespace HotelManagementSystem.Models
{
    public class User : EntityBase
    {
        public User(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
