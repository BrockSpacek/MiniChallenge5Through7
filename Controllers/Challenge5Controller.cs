
using Microsoft.AspNetCore.Mvc;
using MiniChallenge5Through7.services;

namespace MiniChallenge5Through7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Challenge5Controller : ControllerBase
    {
         private readonly Challenge5Services _challenge5Services;

        public Challenge5Controller(Challenge5Services challenge5Services)
        {
          _challenge5Services = challenge5Services;
        }

        [HttpPost]
         [Route("Madlibs/{enterName}/{enterNumberOne}/{enterNameTwo}/{enterNumberTwo}/{city}/{animal}/{hobby}/{job}/{car}/{carTwo}/{yesOrNo}")]
         public string madLibs(string enterName, string enterNumberOne, string enterNameTwo, string enterNumberTwo, string city, string animal, string hobby, string job, string car, string carTwo, string yesOrNo)
        {
            return _challenge5Services.madLibs(enterName, enterNumberOne, enterNameTwo, enterNumberTwo, city, animal, hobby, job, car, carTwo, yesOrNo);
        }
    }
}