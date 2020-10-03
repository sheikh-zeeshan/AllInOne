using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Models.MVVM
{

    public class RegisterViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }

        public string Email { get; set; }
    }
    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public IFormFile Image { get; set; } = null;

        public string CurrentImage { get; set; } = "";

        public string Description { get; set; }
        public string Tags { get; set; }
        public string Category { get; set; }
    }


    public class CommentViewModel
    {
        public int PostId { get; set; }
        public int MainCommentId { get; set; }
        public string Message { get; set; }
    }

}
