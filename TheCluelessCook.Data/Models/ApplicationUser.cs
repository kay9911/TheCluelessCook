﻿using Microsoft.AspNetCore.Identity;
using System;

namespace TheCluelessCook.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        public DateTime MemberSince { get; set; }
    }
}
