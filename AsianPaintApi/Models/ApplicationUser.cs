﻿using Microsoft.AspNetCore.Identity;

namespace AsianPaintApi.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }
    }
}
