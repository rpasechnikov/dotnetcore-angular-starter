using Demo.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        private IFruitService _fruitService;

        public FruitsController(IFruitService fruitService)
        {
            _fruitService = fruitService;
        }

        /// <summary>
        /// GET api/fruits
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllValues()
        {
            return Ok(_fruitService.GetAllFruits());
        }
    }
}
