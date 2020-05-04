using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace interest_rate.Controllers
{
    [ApiController]
    [Route("/calculajuros")]
    public class CalculaJurosController : ControllerBase
    {
        private const string apiRate = "http://127.0.0.1:5000/taxajuros";
        private static readonly HttpClient _httpClient= new HttpClient();

        [HttpPost]
        public ActionResult<string> Post([FromQuery] double valorinicial, double meses)
        {
            Double M, i;

            string resultRate = GetRate().Result;
            i = Convert.ToDouble(resultRate);
            Console.WriteLine(resultRate);

            M = valorinicial * Math.Pow(i + 1, meses);
            
            string rateInterestFormat = M.ToString("F");
            return rateInterestFormat;
        }

        public static async Task<string> GetRate()
        {         
            using (var result = await _httpClient.GetAsync(apiRate))
            {
                string content = await result.Content.ReadAsStringAsync();
                return content;
            }

        }
    
    }

}