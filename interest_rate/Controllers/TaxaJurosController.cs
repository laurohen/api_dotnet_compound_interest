using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace interest_rate.Controllers
{
    [ApiController]
    [Route("/taxajuros")]
    public class TaxaJurosController : ControllerBase
    {
        
        [HttpGet]
        public ActionResult<string> Get()
        {
            double rateInterest = 0.01 ;
            string rateInterestFormat = rateInterest.ToString("F");
            return rateInterestFormat;
        }
    
    
    }

}