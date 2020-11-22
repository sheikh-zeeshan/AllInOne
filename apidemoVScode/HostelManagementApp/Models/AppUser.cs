using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementApp.Models
{

    public class AppUser : IdentityUser
    {

    }
    public class AppUserModel
    {

        public int AppUserId { get; set; }
        public String Name { get; set; }
        public String FatherName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime JoininDate { get; set; }
        public string PhotoURL { get; set; }
        public int RoleId { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public ICollection<AppRole> Roles { get; set; }
        public bool IsActive { get; set; }
        public HostelBranch Branch { get; set; } //1 to 1
 

    }
}
