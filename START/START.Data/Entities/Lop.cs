using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace START.Data.Entities
{
    [Table("Lop")]
    public class Lop
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int numberSinhVien { get; set; }
    }
}
