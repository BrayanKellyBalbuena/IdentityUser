﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Users.Models;

namespace Users.Infrastructure
{
    public class CustomUserValidator : UserValidator<AppUser>
    {
        public CustomUserValidator(AppUserManager mgr) : base(mgr)
        {
            
        }

        public override async Task<IdentityResult> ValidateAsync(AppUser user) {
            IdentityResult result = await base.ValidateAsync(user);

            if (!user.Email.ToLower().EndsWith("example.com"))
            {
                var errors = result.Errors.ToList();
                errors.Add("Only example.com email address are allowed");
                result = new IdentityResult(errors);
            }
            return result;
        }
    }
}