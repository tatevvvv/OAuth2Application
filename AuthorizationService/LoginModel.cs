﻿namespace UserAuthorizationService.Models
{
    public record LoginModel
    {
        public string Username { get; init; }
        public string Password { get; init; }
    }
}
