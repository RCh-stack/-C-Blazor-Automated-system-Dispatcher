using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class WaybillModel
    {
        public int ID { get; set; }
        public int ID_Car { get; set; }
        public int ID_Claim { get; set; }
        public string PointStart { get; set; }
        public string PointEnd { get; set; }
        public DateTime TodayDate { get; set; }
    }
}
