using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementApp.Models.MVVM
{
    public class UserModel
    {

        public int userId { get; set; }
        public string email { get; set; }
        public string username { get; set; }

        public List<String> Roles { get; set; }
        public string  Password { get; set; }
    }
}
