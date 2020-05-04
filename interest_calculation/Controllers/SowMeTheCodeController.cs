using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace interest_rate.Controllers
{
    [ApiController]
    [Route("/showmethecode")]
    public class ShowMeTheCodeController : ControllerBase
    {
        
        [HttpGet]
        public ActionResult<string> Get()
        {
            string urlGit = "https://github.com/laurohen/api_dotnet_compound_interest";
            return urlGit;
        }
    
    
    }

}