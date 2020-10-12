using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementApp.Models
{
    public class AppUsersRoles
    {

        public int Id { get; set; }

        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }

        public AppRole AppRoles { get; set; }
        public int AppRoleId { get; set; }

    }
}
