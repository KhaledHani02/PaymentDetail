using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentDetail.Model
{
    public class Utenti
    {
        [Key]
        public int IdUtente { get; set; }
        [Required]
        public string NomeUtente{ get; set; }
        [Required]
        public string Password{ get; set; }

    }
}
