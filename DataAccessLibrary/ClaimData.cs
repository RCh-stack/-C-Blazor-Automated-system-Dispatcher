using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ClaimData : IClaimData
    {
        private readonly ISqlDataAccess _db;

        public ClaimData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ClaimModel>> GetClaim()
        {
            string sql = "select * from dbo.Claim";

            return _db.LoadData<ClaimModel, dynamic>(sql, new { });
        }

        public Task InsertClaim(ClaimModel claim)
        {
            string sql = @"insert into dbo.Claim (Name, Loading, Unloading, Payment, Weight, Date, Ending, 
                            PointXStart, PointYStart, PointXEnd, PointYEnd) 
                            values (@Name, @Loading, @Unloading, @Payment, @Weight, @Date, @Ending,
                            @PointXStart, @PointYStart, @PointXEnd, @PointYEnd);";

            return _db.SaveData(sql, claim);
        }

        public Task DeleteClaim(ClaimModel claim)
        {
            string sql = @"delete from dbo.Claim where ID = @id;";

            return _db.SaveData(sql, claim);
        }

        public Task UpdateClaim(ClaimModel claim)
        {
            string sql = @"update dbo.Claim set Name = @Name, Loading = @Loading, Unloading = @Unloading,
                    Payment = @Payment, Weight = @Weight, Date = @Date, Ending = @Ending,
                    PointXStart = @PointXStart, PointYStart = @PointYStart, PointXEnd = @PointXEnd, 
                    PointYEnd = @PointYEnd where ID = @id;";

            return _db.SaveData(sql, claim);
        }
    }
}
