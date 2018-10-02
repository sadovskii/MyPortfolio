using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortfolio.DAL.Models
{
    public class TypeRecord : BaseEntity
    {
        public string Name { get; set; }
        public List<Category> Categories { get; set; }
        public List<Record> Records { get; set; }
    }
}
