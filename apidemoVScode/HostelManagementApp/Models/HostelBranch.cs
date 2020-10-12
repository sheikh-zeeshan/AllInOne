using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementApp.Models
{
    public class HostelBranch
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public Hostel Hostel { get; set; } //for 1 to many

        public AppUser  User { get; set; }
        public int AppUserIdRef { get; set; }  //for 1 to 1 relation
    }
}
