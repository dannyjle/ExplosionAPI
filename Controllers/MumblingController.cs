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
    public class MumblingController : ControllerBase
    {
        [HttpGet]
        public string Mumbling(string who)
        {
            var accumStr = "";
            var charList = new List<char>(who);
            for (var i = 0; i < charList.Count; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        accumStr += char.ToUpper(charList[i]);
                    }
                    else
                    {
                        accumStr += char.ToLower(charList[i]);
                    }
                }
                if (i != charList.Count - 1)
                {
                    accumStr += "-";
                }
            }
            return accumStr;

        }

    }
}