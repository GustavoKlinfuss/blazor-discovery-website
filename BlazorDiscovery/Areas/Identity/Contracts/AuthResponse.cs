﻿namespace BlazorDiscovery.Areas.Identity.Contracts
{
    public class AuthResponse
    {
        public string? UserId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public List<string>? Roles { get; set; }
        public string? Token { get; set; }
    }
}
