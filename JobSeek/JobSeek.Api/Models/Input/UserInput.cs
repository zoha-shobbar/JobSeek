﻿namespace JobSeek.Api.Models.Input
{
    public abstract class UserInput
    {
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        public int PostalCode { get; set; }
    }
}
