﻿using Microsoft.AspNetCore.Mvc;

namespace Fwk.Infrastructure.Host.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerformQueryHandlerController
    {
        [HttpPost]
        [HttpGet]
        public ValueTask<int> Process(object body)
        {
            return new ValueTask<int>(1);
        }
    }
}
