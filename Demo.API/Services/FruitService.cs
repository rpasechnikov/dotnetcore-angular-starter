using Demo.API.Models;
using Demo.API.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Demo.API.Services
{
    public class FruitService : IFruitService
    {
        private readonly DemoContext _context;

        public FruitService(DemoContext context)
        {
            _context = context;
        }

        public ICollection<Fruit> GetAllFruits()
        {
            return _context.Fruits.ToList();
        }

        public Fruit GetFruit(int id)
        {
            return _context.Fruits.FirstOrDefault(fruit => fruit.Id == id);
        }

        public bool CreateFruit(Fruit fruit)
        {
            _context.Fruits.Add(fruit);
            _context.SaveChanges();

            return true;
        }

        public bool DeleteFruit(int id)
        {
            var fruitToDelete = _context.Fruits.FirstOrDefault(fruit => fruit.Id == id);

            _context.Fruits.Remove(fruitToDelete);
            _context.SaveChanges();

            return true;
        }
    }
}
