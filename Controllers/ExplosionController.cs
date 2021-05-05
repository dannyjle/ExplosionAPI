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
    public class ExplosionController : ControllerBase
    {
        [HttpGet]
        public string Explosion(int who)
        {
            var w = $"{who}";
            var expStr = "";

            for (var i = 0; i < w.Length; i++)
            {
                var numChar = w[i].ToString();
                var num = int.Parse(numChar);
                for (var j = 0; j < num; j++)
                {
                    expStr += numChar;
                }
            }
            return expStr;
        }
    }
}