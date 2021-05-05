using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseStringController : ControllerBase
    {
        [HttpGet]
        public string Reverse(string who)
        {

            string flip;

            if (who == null)
            {
                flip = "No Name";
            }
            else
            {
                flip = who;
            }


            return String.Join("", flip.Reverse());

        }

    }
}