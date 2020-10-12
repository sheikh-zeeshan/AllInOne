using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Entities.Administrator
{

    public class Roles
    {
        public string Name { get; set; } = "Super admin, admin, accountatn, branchMember, hostelLites";
    }
    public class Tenent
    {
        public string OwnerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Branch> Braqnches { get; set; }
    }
    public class Branch
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Capacity { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }
        public string Footer { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
    }

    public class BranchCategory
    {
        public string Castegory { get; set; } = "Five star";
        public string Note { get; set; }
    }
}
