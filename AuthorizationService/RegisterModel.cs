﻿namespace UserAuthorizationService.Models
{
    public record RegisterModel
    {
        public string Username { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
    }
}
