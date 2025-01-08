
using Microsoft.AspNetCore.Mvc;
using MiniChallenge5Through7.services;

namespace MiniChallenge5Through7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Challenge7ControllerPart2 : ControllerBase
    {
         private readonly Challenge7ServicesPart2 _challenge7ServicesPart2;

        public Challenge7ControllerPart2(Challenge7ServicesPart2 challenge7ServicesPart2)
        {
          _challenge7ServicesPart2 = challenge7ServicesPart2;
        }

        [HttpPost]
        [Route("reverseString/{password}")]
        public string reverseString(string password){
            return _challenge7ServicesPart2.reverseString(password);
        }
    }
}