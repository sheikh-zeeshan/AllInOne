using System;

namespace HMS.Entities
{
    public class GeneralSettings
    {
        public string SiteTitle { get; set; }
        public string Phone { get; set; }
        public String Email { get; set; }
        public string Footer { get; set; } = "Copyright &copy; Ihostel School Management";
        public string Address { get; set; }
        public string Logo { get; set; }

        public int MyProperty { get; set; }
        public bool ProfileEdit { get; set; }
        public bool ShowBranches { get; set; }
        public bool AutoUpdateNotification { get; set; }
    }

    public class EmailSettings
    {
        public string SMTPUserName { get; set; }
        public string SMTPPassword { get; set; }
        public string SMTPServer { get; set; }
        public string SMTOPort { get; set; }
        public String SMTOSecurity { get; set; }

    }
}
