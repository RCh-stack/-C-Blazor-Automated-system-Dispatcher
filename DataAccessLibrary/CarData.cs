using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CarData : ICarData
    {
        private readonly ISqlDataAccess _db;

        public CarData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CarModel>> GetCar()
        {
            string sql = "select * from dbo.Car";

            return _db.LoadData<CarModel, dynamic>(sql, new { });
        }

        public Task InsertCar(CarModel car)
        {
            string sql = @"insert into dbo.Car (Fullname, Brand, Speed, Capacity)
                            values (@Fullname, @Brand, @Speed, @Capacity);";

            return _db.SaveData(sql, car);
        }

        public Task DeleteCar(CarModel car)
        {
            string sql = @"delete from dbo.Car where ID = @id;";

            return _db.SaveData(sql, car);
        }

        public Task UpdateCar(CarModel car)
        {
            string sql = @"update dbo.Car set Fullname = @Fullname, Brand = @Brand,
                        Speed = @Speed, Capacity = @Capacity where ID = @id;";

            return _db.SaveData(sql, car);
        }
    }
}
