using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
 
using MyValidationAttribute = BlogSite.Helpers.CustomValidationAttribute;

namespace BlogSite.Models
{
    [Table("Books")]
    public class Book
    {
       

        public int Id { get; set; }
        
        //[Required(ErrorMessage ="Book name is required")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Book author is required")]
        public string AuthName { get; set; }

       //[Required(ErrorMessage = "Book title is required")]
        public string Title { get; set; }

        public string ShortDescp { get; set; }
        public string LongDescp { get; set; }
        public string ThumbnailURL { get; set; }
        public string Category { get; set; }
        [Display(Name ="Total pages in book")]
        public int TotalPages { get; set; }
        public string Language { get; set; }
        public string BookPdfUrl { get; set; }

        public List<BookGallery> BookGalleries { get; set; }
        public Book()
        {
            BookGalleries = new List<BookGallery>();
        }
    }

    [Table("BookGallery")]
    public class BookGallery
    {
        public int BookId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }

        public Book Book { get; set; }
    }

    public class BookModel
    {
        public int Id { get; set; }

        //[StringLength(100, MinimumLength =5)]
        //[Required(ErrorMessage ="Enter book title")]
        
        [MyValidationAttribute(ErrorMessage ="hello pls provide corect val that contains MVC in Title", Text="mvc")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Enter author name")]
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public int? TotalPages { get; set; }

        [DataType(DataType.Date)]
        public string CreatedOn { get; set; }

        [Display(Name ="choose the cover photo")]
        public IFormFile  CoverPhoto { get; set; }

        [Display(Name = "choose photos")]
        public IFormFileCollection CoverPhotos { get; set; }

        public List<GalleryModel> Gallery { get; set; }

        public string FilePath { get; set; }

        public Book FromModel()
        {
            return new Book {
            
            Id = this.Id,
            Title= this.Title,
            Name= this.Title,
            AuthName = this.Author,
            LongDescp = this.Description,
            Category= this.Category,
            Language= this.Language,
            TotalPages = this.TotalPages.GetValueOrDefault(0) ,
            ThumbnailURL= this.FilePath,
                 

            };
        }
    }

    public class GalleryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
    }

    public class LanguageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
