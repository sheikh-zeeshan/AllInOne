using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementApp.Models
{
    public class Permissions
    {

        public int Id { get; set; }
        public string Module { get; set; }
        public bool Add { get; set; }
        public bool  Edit { get; set; }
        public bool Delete { get; set; }
        public bool View { get; set; }

    }
}
