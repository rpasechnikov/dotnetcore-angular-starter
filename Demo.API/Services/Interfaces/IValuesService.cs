using System.Collections.Generic;

namespace Demo.API.Services.Interfaces
{
    public interface IValuesService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ICollection<string> GetAllValues();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string GetValue(int id);
    }
}
