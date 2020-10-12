using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementApp.Models
{
    public class AppRole
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ICollection<AppUser> AppUsers { get; set; }

    }

    /*
        superadmin
        hostlowner
        branchvardan
        branchuser
        user

     */
}
