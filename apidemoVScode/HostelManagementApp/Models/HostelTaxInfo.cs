using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementApp.Models
{
    public class HostelTaxRegisterationInfo
    {

        public int Id { get; set; }
        public DateTime TaXSubmittedDate { get; set; }
        public decimal Amount { get; set; }

        public Hostel Hostel { get; set; }
        public int HostelRefId { get; set; }  //for 1 to 1 relation
    }
}
