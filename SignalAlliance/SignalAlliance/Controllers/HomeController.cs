using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static SignalAlliance.Controllers.iincontrol;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SignalAlliance.Controllers
{
    
    [Route("api/iin=53241982")]
    [ApiController]
    public class HomeController : ControllerBase
    {    

        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger)
            {
                _logger = logger;
            }

        [HttpGet]
        public IActionResult Get()
        {
            
            var result = new iincontrol
            {
                scheme = "visa",
                type = "debit",
                brand = "Visa/Dankort",
                prepaid = "false",
                country = new coutry
                {
                    name = "Denmark",
                    currency = "DKK"
                },
                bank = new banking
                {
                    name = "Jyske Bank",
                    url = "https://ddec1-0-en-ctp.trendmicro.com:443/wis/clicktime/v1/query?url=www.jyskebank.dk%22&umid=40e4dcea-cb0e-486d-99b6-603aa4107153&auth=f51a37eaa094ea7fb156f9a74edf7935d59d5a75-035e173138b94a0d4be9b529a0b7615d60cf3a66",
                    phone = "+4589893300",
                    city =  "Hjørring"
                },
            };
        
            return new JsonResult(result);
        }  

    }
}
