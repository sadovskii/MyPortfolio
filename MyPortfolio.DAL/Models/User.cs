using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyPortfolio.DAL.Models
{
    public class User : IdentityUser
    {
        public List<Comment> Comments { get; set; }
        public List<Record> Records { get; set; }

        public Role Role { get; set; }
    }
}
