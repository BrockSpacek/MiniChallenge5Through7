
using Microsoft.AspNetCore.Mvc;
using MiniChallenge5Through7.services;

namespace MiniChallenge5Through7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Challenge6Controller : ControllerBase
    {
         private readonly Challenge6Services _challenge6Services;

        public Challenge6Controller(Challenge6Services challenge6Services)
        {
          _challenge6Services = challenge6Services;
        }

        [HttpPost]
        [Route("oddOrEven/{enterNumber}")]

        public string oddOrEven(string enterNumber)
        {
            return _challenge6Services.oddOrEven(enterNumber);
        }
    }
}