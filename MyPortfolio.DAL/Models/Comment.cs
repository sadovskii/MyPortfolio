using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyPortfolio.DAL.Models
{
    public class Comment : BaseEntity
    {
        [Required]
        public string Content { get; set; }
        public User User { get; set; }
        public Record Record { get; set; }
    }
}
