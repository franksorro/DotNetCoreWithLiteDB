using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FS.Interfaces;
using DotNetCoreWithLiteDB.Models;

namespace DotNetCoreWithLiteDB.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class TestController : BaseController
    {
        private readonly ILiteDBService service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public TestController(ILiteDBService service)
        {
            this.service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await service.Get<TestModel>("test"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add()
        {
            var model = new TestModel
            {
                Id = 1,
                Label = "Test"
            };

            return Ok(await service.Insert("test", model));
        }
    }
}
