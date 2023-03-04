using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentDetail.Model;

namespace PaymentDetail.Controllers
{
    
    [Route("api/Card")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly Context _db;

        public HomeController(Context db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok( await _db.card.ToListAsync());
        }

        


    }
   
}
