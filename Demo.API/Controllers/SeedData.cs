using Demo.API.Models;
using Demo.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedData : ControllerBase
    {
        private readonly DemoContext _context;

        public SeedData(DemoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult CreateSomeFruits()
        {
            for (var i = 0; i < 10; i++)
            {
                _context.Fruits.Add(
                    new Fruit
                    {
                        Name = $"Fruit {i}",
                        Weight = i
                    });
            }

            _context.SaveChanges();
            return Ok();
        }
    }
}
