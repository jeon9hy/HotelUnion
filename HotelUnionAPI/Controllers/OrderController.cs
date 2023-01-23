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
    [Route("api/v2")]
    public class OrderController : ControllerBase
    {
        private OrderService DB = new OrderService();

        [HttpPost("reservation")]
        public ActionResult Reservation([FromBody] Order o)
        {

            int anw = DB.Reservation(o);

            if (anw == 1)
            {
                return StatusCode(StatusCodes.Status200OK, true);
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, false);
            }

        }
        [HttpPost("cancel")]
        public ActionResult Cancel([FromBody] Order o)
        {

            int anw = DB.Cancel(o);

            if (anw == 1)
            {
                return StatusCode(StatusCodes.Status200OK, true);
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, false);
            }

        }
        [HttpPost("review")]
        public ActionResult Review([FromBody] Order o)
        {

            int anw = DB.Review(o);

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
