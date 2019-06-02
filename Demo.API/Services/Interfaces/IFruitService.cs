using Demo.API.Models;
using System.Collections.Generic;

namespace Demo.API.Services.Interfaces
{
    public interface IFruitService
    {
        ICollection<Fruit> GetAllFruits();
        Fruit GetFruit(int id);
        bool CreateFruit(Fruit fruit);
        bool DeleteFruit(int id);
    }
}
