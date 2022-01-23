using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IWaybillData
    {
        Task<List<WaybillModel>> GetWaybill();
        Task InsertWaybill(WaybillModel waybill);
        Task DeleteWaybill(WaybillModel waybill);
        Task UpdateWaybill(WaybillModel waybill);
    }
}