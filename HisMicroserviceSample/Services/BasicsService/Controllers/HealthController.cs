using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BasicsService.Controllers
{
    [Route("api/[controller]")]
    public class HealthController : Controller
    {
        /// <summary>
        /// 主健康检查
        /// </summary>
        /// <returns></returns>
        [HttpGet("/health")]
        public IActionResult KeyHealth()
        {
            return Content("BasicsService KeyHealth检查成功！");
        }
    }
}
