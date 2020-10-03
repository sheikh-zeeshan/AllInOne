using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSite.Data;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using BlogSite.Models;

namespace BlogSite.Controllers
{
    public class BookController : Controller
    {
        IRepository _repo;
     

        public BookController(IRepository repo)
        {
            _repo = repo;
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
        public IActionResult AddNewBook(bool isSuccess=false, int bid =0)
        {
            ViewBag.IsSuccess = isSuccess; //this will be used when save is called
            ViewBag.Id = bid;
            return View();

        }

        [HttpPost]
        public IActionResult AddNewBook(Book bk)
        {
            var savedToDB = true;
            if (savedToDB)
                return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bid = 1 });


                return View();
        }
    }
}
