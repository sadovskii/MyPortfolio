using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortfolio.DAL.Models
{
    public class Role : IdentityRole
    {
        List<Role> Roles { get; set; }
    }
}
