using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlogSite.Models;
using BlogSite.Data;
using System.Threading;
using Microsoft.EntityFrameworkCore.Design;
using System.Runtime.InteropServices.WindowsRuntime;
using System.IO;
using BlogSite.Data.FileManager;
using BlogSite.Models.MVVM;

//1 install it -> dotnet tool install --global dotnet-ef
//2. issue cmd -> dotnet-ef migrations add "identity"
//3.. issue cmd -> dotnet-ef database update


namespace BlogSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRepository _repo;
        IFileManager _file;
        public HomeController(ILogger<HomeController> logger, IRepository repo, IFileManager file)
        {
            _logger = logger;
            _repo = repo;
            _file = file;
        }

        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Index(string category)
        {
            var post = string.IsNullOrEmpty(category) ? _repo.GetAllPosts() : _repo.GetAllPosts(category);
            return View(post);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
        public IActionResult Post(int id)
        {
            var post = _repo.GetPost(id);
            return View(post);
        }

        [HttpGet]
        public IActionResult Edit(int? id) {

             

            if (id == null) return View(new Post());

            var post = _repo.GetPost((int)id);
            return View(post);
        
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Post model)
        {
            if (model.Id > 0)
                _repo.EditPost(model);
            else
                _repo.AddPost(model);

            if (await _repo.SaveChangesAsyc())
                return RedirectToAction("Index");
            else
                return View(model);


        }

        public async Task<IActionResult> Remove(int id)
        {
            _repo.RemovePost(id);

            await _repo.SaveChangesAsyc();

            return RedirectToAction("Index");
        }

        [HttpGet("/Image/{image}")]
        public IActionResult Image(string image)
        {
            try
            {
                var mimeType = image.Substring(image.LastIndexOf('.') + 1);

                return new FileStreamResult(_file.ImageStream(image), $"image/{mimeType}");
            }catch(Exception ex) { return null; }
        }

        [HttpPost]
        public async Task<IActionResult> Comment(CommentViewModel vm)
        {
            if (!ModelState.IsValid) return RedirectToAction("Post", new { id=vm.PostId });

            var post = _repo.GetPost(vm.PostId);
            if (vm.MainCommentId > 0)
            {
                post.MainComments = post.MainComments ??
                    new List<MainComments>();

                post.MainComments.Add(new MainComments
                {
                    Message = vm.Message,
                    Created = DateTime.Now,
                });

                _repo.EditPost(post);
            }
            else
            {
                var comments = new SubComments
                {
                    MainCommentsId = vm.MainCommentId,
                    Message = vm.Message,
                    Created = DateTime.Now
                };
            }

            await _repo.SaveChangesAsyc();

            return View();
        }
    }
}
