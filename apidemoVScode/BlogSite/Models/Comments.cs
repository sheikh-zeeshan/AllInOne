using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Models
{
    public class Comments
    {

        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }

    }

    public class MainComments : Comments
    {
        public List<SubComments> SubComments { get; set; }

    }

    public class SubComments : Comments
    {
        public int MainCommentsId { get; set; }
    }
}
