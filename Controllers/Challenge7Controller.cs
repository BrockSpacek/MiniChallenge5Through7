
using Microsoft.AspNetCore.Mvc;
using MiniChallenge5Through7.services;

namespace MiniChallenge5Through7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Challenge7Controller : ControllerBase
    {
         private readonly Challenge7Services _challenge7Services;

        public Challenge7Controller(Challenge7Services challenge7Services)
        {
          _challenge7Services = challenge7Services;
        }

        [HttpPost]
        [Route("reverseNumber/{inputNumber}")]
        public string reverseNumber(string inputNumber){
            return _challenge7Services.reverseNumber(inputNumber);
        }
    }
}