﻿using Microsoft.AspNetCore.Identity;

namespace AuthenticationDemo.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = string.Empty;
    }
}
