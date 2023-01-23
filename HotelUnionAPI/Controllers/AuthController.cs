using HotelUnionAPI.Models;
using HotelUnionAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelUnionAPI.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class AuthController : ControllerBase
    {
        private AuthService DB = new AuthService();

        [HttpPost("login")]
        public ActionResult login([FromBody] Auth auth)
        {

            int anw = DB.Login(auth);

            if (anw == 1)
            {
                return StatusCode(StatusCodes.Status200OK, true);
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, false);
            }

        }

        [HttpPost("newmember")]
        public ActionResult newmember([FromBody] Auth auth)
        {
            int anw = DB.NewMember(auth);

            if (anw == 1)
            {
                return StatusCode(StatusCodes.Status200OK, true);
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, false);
            }
        }

        [HttpPost("idcheck")]
        public ActionResult idcheck([FromBody] Auth auth)
        {
            int anw = DB.IdCheck(auth);

            if (anw == 0)
            {
                return StatusCode(StatusCodes.Status200OK, true);
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, false);
            }
        }

        [HttpPost("changeinfo")]
        public ActionResult changeinfo([FromBody] Auth auth)
        {
            int anw = DB.changeinfo(auth);

            if (anw == 1)
            {
                return StatusCode(StatusCodes.Status200OK, true);
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, false);
            }
        }
        [HttpPost("withdraw")]
        public ActionResult withdraw([FromBody] Auth auth)
        {
            int anw = DB.Withdraw(auth);

            if (anw == 1)
            {
                return StatusCode(StatusCodes.Status200OK, true);
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, false);
            }
        }

    }
}
