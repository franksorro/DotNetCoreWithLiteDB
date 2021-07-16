﻿using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWithLiteDB.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [
        ApiController,
        Route("api/[controller]/[action]"),
        Produces("application/json")
    ]
    public class BaseController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        public BaseController() { }
    }
}