using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyPortfolio.DAL.Models
{
    public class Record : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }
        public User User { get; set; }
        public int? TypeRecordId { get; set; }
        public TypeRecord TypeRecord { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
