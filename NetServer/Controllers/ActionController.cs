using Microsoft.AspNetCore.Mvc;
using Kontroller.Helper.Windows;
using Otp = Kontroller.Helper.Otp;

namespace Kontroller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string token, string want)
        {
            if (!Config.IsDebug && !string.IsNullOrEmpty(Config.OtpKey))
            {
                if (!Otp.Check(Config.OtpKey, token))
                    return Forbid();
            }

            switch (want.ToLower())
            {
                case "vol-up":
                    Vol.Up();
                    break;
                case "vol-down":
                    Vol.Down();
                    break;
                case "vol-mute":
                    Vol.Mute();
                    break;
                case "media-next":
                    Media.Next();
                    break;
                case "media-prev":
                    Media.Previous();
                    break;
                case "media-pause":
                case "media-play":
                case "media-stop":
                    Media.Play();
                    break;
                default:
                    return BadRequest();
            }

            return Ok();
        }
    }
}