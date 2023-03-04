using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PaymentDetail.Model;
using System;
using System.Threading.Tasks;

namespace PaymentDetail.Controllers
{
    [Route("Controlla")]
    [ApiController]
    public class UtenteOkController : Controller
    {
        private readonly Context _db;
        public UtenteOkController( Context dbContext)
        {
            _db = dbContext;
        }


        [HttpPost("api/Controlla")]
        public async Task<bool> ControllaDati([FromBody] LoginDto login)
        {
            // Effettuare la query al database per verificare se i dati sono presenti
            var datiPresenti = await _db.utenti.FirstOrDefaultAsync(x => x.NomeUtente == login.Utente && x.Password == login.Password);

            return datiPresenti != null ? true : false;
        }


        [HttpPost("inserisci-dati")]
        public async Task<IActionResult> InserisciDati([FromBody] Utenti dati)
        {
            try
            {
                // Inserire i dati nel database
                _db.utenti.Add(dati);
                await _db.SaveChangesAsync();

                return Ok("I dati sono stati inseriti nel database");
            }
            catch
            {
                return StatusCode(500, "Errore durante l'inserimento dei dati nel database");
            }
        }
    }
}
