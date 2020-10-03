using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSite.Data;
using BlogSite.Data.FileManager;
using BlogSite.Models;
using BlogSite.Models.MVVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    [Authorize]
    public class PanelController : Controller
    {
        IRepository _repo;
        IFileManager _file;

        public PanelController(IRepository repo, IFileManager file)
        {
            _repo = repo;
            _file= file;
        }
        public IActionResult Index()
        {
            var posts = _repo.GetAllPosts();
            return View(posts);
        }

        

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View(new PostViewModel());
            }
            else
            {
                var post = _repo.GetPost((int)id);
                return View(
                    new PostViewModel { 
                        Body = post.Body,
                        Id= post.Id,
                        CurrentImage = post.Image,
                        Title= post.Title,
                        Category=post.Category,
                        Tags=post.Tags,
                        Description=post.Description
                    }
                    );
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PostViewModel model)
        {
            var post = new Post {
                Id = model.Id,
                Title= model.Title,
                Body= model.Body,
                Created= DateTime.Now,
               // Image= await _file.SaveImage(model.Image)
               Category= model.Category,
               Description=model.Description,
               Tags=model.Tags
            };

            if (model.Image == null)
                post.Image = model.CurrentImage;
            else
            {
                if (string.IsNullOrEmpty(model.CurrentImage))
                    _file.RemoveImage(model.CurrentImage);

                post.Image = await _file.SaveImage(model.Image);
            }
            if (model.Id > 0)
                _repo.EditPost(post);
            else
                _repo.AddPost(post);

            if (await _repo.SaveChangesAsyc())
            {
                return RedirectToAction("Index");
            }
            else
                return View(post);
        }


    }
}
