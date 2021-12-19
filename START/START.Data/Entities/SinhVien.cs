using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace START.Data.Entities
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }
}
