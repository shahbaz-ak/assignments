using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace assignment2.Entities
{
    public class entitiyCustomer
    {
        [Key]
        [StringLength(5)]
        public string Cid { get; set; }
        [StringLength(30)]
        [Required]
        public string Cname { get; set; }
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public string? City { get; set; }

    }
}
