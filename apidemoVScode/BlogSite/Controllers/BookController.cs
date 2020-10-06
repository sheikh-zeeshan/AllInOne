using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSite.Data;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using BlogSite.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.IO.MemoryMappedFiles;

namespace BlogSite.Controllers
{
    public class BookController : Controller
    {
        IBookRepository _repo;

        IWebHostEnvironment _host;
        public BookController(IBookRepository repo, IWebHostEnvironment host)
        {
            _repo = repo;
            _host = host;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllBooks()
        {

            var result = _repo.GetAllBooks("");

            return View(result);
        }

        public async Task<IActionResult> GetTopBooksAsync()
        {

            var result =await  _repo.GetTopBooksAsync();

            return View(result);
        }

        // [Route("book-details/{id}",Name ="_rtbkdetailById")]
        public ViewResult GetBook(int id)
        {
            if (id == 0) return null;

            dynamic _data = new ExpandoObject();
            _data.Id = 1;
            _data.Name = "expando object";
            ViewBag.Data = _data;


            var data = _repo.GetBookById(id);
            return View(data);
        }

        public IActionResult Books(string category)
        {
            var result = _repo.GetAllBooks(category);

            return View(result);
        }

        [HttpGet]
        public IActionResult AddNewBook(bool isSuccess = false, int bid = 0)
        {

            ViewBag.IsSuccess = isSuccess; //this will be used when save is called
            ViewBag.Id = bid;

            //ViewBag.Languages =new SelectList( new List<String> { "English", "Urdu", "French" },"Urdu");

            //OR
            //ViewBag.Languages = new SelectList(GetLanguages(),
            //        "Id",
            //        "Name" 
            //        );

            //OR

            var group1 = new SelectListGroup() { Name = "group1" };
            var group2 = new SelectListGroup() { Name = "group2" };
            var group3 = new SelectListGroup() { Name = "group3", Disabled = true };

            ViewBag.Languages = new List<SelectListItem>()
            {
                new SelectListItem(){Text="English", Value="1", Group=group1},
                new SelectListItem(){Text="Urdu", Value="2",  Disabled=true , Group=group1},
                new SelectListItem(){Text="French", Value="3" , Selected=true , Group=group2},

                     new SelectListItem(){Text="Pubjabi", Value="4"   , Group=group3},
                          new SelectListItem(){Text="Sindhee", Value="5" , Group=group3},
            };


            BookModel model = new BookModel
            {
                Language = "3"  //disabled when selected listitem  is passed
            }; //set the drop down value
            return View(model);

        }

        private static List<LanguageModel> GetLanguages()
        {
            return new List<LanguageModel> {
                    new LanguageModel{ Id=1, Name="English" },
                    new LanguageModel{ Id=2, Name="Urdu" },
                    new LanguageModel{ Id=3, Name="French" },
                    };
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewBook(BookModel mv)
        {
            if (ModelState.IsValid)
            {

                if (mv.CoverPhoto != null)
                {
                    string fileName = Guid.NewGuid().ToString() + "_" + mv.CoverPhoto.FileName;
                    string folder = @"book\cover\" + fileName;
                    string serverFolder = Path.Combine(_host.WebRootPath, folder);

                    UploadFile(serverFolder, mv.CoverPhoto);
                    mv.FilePath = fileName;

                }
                if (mv.CoverPhotos != null)
                {
                    mv.Gallery = new List<GalleryModel>();
                    foreach (var item in mv.CoverPhotos)
                    {
                        string fileName = Guid.NewGuid().ToString() + "_" + item.FileName;
                        string folder = @"book\gallery\" + fileName;
                        string serverFolder = Path.Combine(_host.WebRootPath, folder);

                        UploadFile(serverFolder, item);

                        mv.Gallery.Add(new GalleryModel { Name = fileName, URL = folder.Substring(0, folder.LastIndexOf(@"\")) });
                    }
                }

                Book bk = mv.FromModel();
                bk.BookGalleries = new List<BookGallery>();
                mv.Gallery.ForEach(x => bk.BookGalleries.Add(new BookGallery
                {
                    BookId = bk.Id,
                    Name = x.Name,
                    URL = x.URL,
                    Id = 0,
                    Book = bk

                }));


                _repo.AddNewBook(bk);
                var savedToDB = _repo.SaveChanges();

                if (savedToDB && bk.Id > 0)
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = savedToDB, bid = bk.Id });
            }

            else
            {
                var errors = ModelState.Select(x => x.Value.Errors)
                                       .Where(y => y.Count > 0)
                                       .ToList();
                var message = string.Join(" | ", ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.ErrorMessage));
            }

            ViewBag.Languages = new SelectList(GetLanguages(),
                     "Id",
                     "Name"
                     );
            ViewBag.IsSuccess = false; //this will be used when save is called
            ViewBag.Id = 0;
            ModelState.AddModelError("", "this error is coming from controller");
            return View();
        }

        [NonAction]
        private void UploadFile(string serverFolder, IFormFile coverPhoto)
        {
            coverPhoto.CopyTo(new FileStream(serverFolder, FileMode.Create));
        }

        //private void UploadFile(BookModel mv)
        //{
        //    string folder = @"book\cover\";

        //    string fileName = Guid.NewGuid().ToString() + "_" + mv.CoverPhoto.FileName;

        //    folder += fileName;

        //    string serverFolder = Path.Combine(_host.WebRootPath, folder);

        //    mv.CoverPhoto.CopyTo(new FileStream(serverFolder, FileMode.Create));
        //    mv.FilePath = fileName;
        //}
    }
}
