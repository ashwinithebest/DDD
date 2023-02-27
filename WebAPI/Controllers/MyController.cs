using Application.Common.Interface;
using Application.Services;
using Domain.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MyController : ControllerBase
    {
        private readonly IAppSettingsRepository _services;
        private readonly CategoryServices categoryServices;

        public MyController(IAppSettingsRepository services,CategoryServices categoryServices)
        {
            _services = services;
            this.categoryServices = categoryServices;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await categoryServices.GetCategoryAsync();
            return Ok(result);
        }

       

                
    }
}
