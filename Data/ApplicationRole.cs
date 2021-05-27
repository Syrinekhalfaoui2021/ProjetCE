﻿using Microsoft.AspNetCore.Identity;

namespace CE.Data
{
    public class ApplicationRole : IdentityRole
    {

        public ApplicationRole()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {

        }
    }

}