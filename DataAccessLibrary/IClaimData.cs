using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IClaimData
    {
        Task<List<ClaimModel>> GetClaim();
        Task InsertClaim(ClaimModel claim);
        Task DeleteClaim(ClaimModel claim);
        Task UpdateClaim(ClaimModel claim);
    }
}