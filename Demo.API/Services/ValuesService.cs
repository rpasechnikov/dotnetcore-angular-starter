using Demo.API.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Demo.API.Services
{
    public class ValuesService : IValuesService
    {
        private Dictionary<int, string> valueMap = new Dictionary<int, string>();

        public ValuesService()
        {
            for (var i = 0; i < 10; i++)
            {
                valueMap.Add(i, $"value {i}");
            }
        }

        public ICollection<string> GetAllValues()
        {
            return valueMap.Values.ToList();
        }

        public string GetValue(int id)
        {
            return valueMap[id];
        }
    }
}
