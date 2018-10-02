using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortfolio.DAL.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int? TypeRecordId { get; set; }
        public TypeRecord TypeRecord { get; set; }
        public List<Record> Records { get; set; }
    }
}
