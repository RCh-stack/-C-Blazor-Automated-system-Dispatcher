using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ICarData
    {
        Task DeleteCar(CarModel car);
        Task<List<CarModel>> GetCar();
        Task InsertCar(CarModel car);
        Task UpdateCar(CarModel car);
    }
}