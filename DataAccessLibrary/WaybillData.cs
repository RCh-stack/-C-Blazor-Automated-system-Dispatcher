using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class WaybillData : IWaybillData
    {
        private readonly ISqlDataAccess _db;

        public WaybillData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<WaybillModel>> GetWaybill()
        {
            string sql = "select * from dbo.Waybill";

            return _db.LoadData<WaybillModel, dynamic>(sql, new { });
        }

        public Task InsertWaybill(WaybillModel waybill)
        {
            string sql = @"insert into dbo.Waybill (ID_Car, ID_Claim, PointStart, PointEnd, TodayDate) 
                        values (@ID_Car, @ID_Claim, @PointStart, @PointEnd, @TodayDate);";

            return _db.SaveData(sql, waybill);
        }

        public Task DeleteWaybill(WaybillModel waybill)
        {
            string sql = @"delete from dbo.Waybill where ID = @id;";

            return _db.SaveData(sql, waybill);
        }

        public Task UpdateWaybill(WaybillModel waybill)
        {
            string sql = @"update dbo.Waybill set ID_Car = @ID_Car, ID_Claim = @ID_Claim, 
                        PointStart = @PointStart, PointEnd = @PointEnd, TodayDate = @TodayDate where ID = @id;";

            return _db.SaveData(sql, waybill);
        }
    }
}
