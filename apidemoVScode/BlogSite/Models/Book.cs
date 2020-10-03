using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthName { get; set; }
        public string Title { get; set; }
        public string ShortDescp { get; set; }
        public string LongDescp { get; set; }
        public string ThumbnailURL { get; set; }
        public string Category { get; set; }
        public string TotalPages { get; set; }
        public string Language { get; set; }
        public string BookPdfUrl { get; set; }
    }
}
