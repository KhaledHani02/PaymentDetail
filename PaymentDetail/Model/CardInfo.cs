using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentDetail
{
    public class CardInfo
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Owner{ get; set; }
        [Required]
        public int CardNum { get; set; }
        [Required]
        public int pin { get; set; }
    }
}
