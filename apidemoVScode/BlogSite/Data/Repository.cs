using BlogSite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BlogSite.Data
{
    public interface IRepository
    {
        public Post GetPost(int id);
        public List<Post> GetAllPosts( );

        public List<Post> GetAllPosts(string category);
        void AddPost(Post post);
        void EditPost(Post post);
        void RemovePost(int id);

        Task<bool> SaveChangesAsyc();

        void AddSubComments(SubComments comment);

       
    }
    public class Repository : IRepository
    {
        AppDbContext _AppContext;
        public Repository(AppDbContext ctx)
        {
            _AppContext = ctx;
        }

        public void AddPost(Post post)
        {
            _AppContext.Posts.Add(post);

           
        }

        public void EditPost(Post post)
        {
            _AppContext.Posts.Update(post);
        }

        public List<Post> GetAllPosts( )
        {
            return _AppContext.Posts.ToList();
        }

        public List<Post> GetAllPosts(string category)
        {
            //Func<Post, bool> Iscat = (post) => { return post.Category.ToLower().Equals(category.ToLower()); };
           //return _AppContext.Posts.Where(x=> Iscat(x)).ToList();


            return _AppContext.Posts.Where(x=>x.Category.ToLower().Equals(category.ToLower())).ToList();
        }

        public Post GetPost(int id)
        {
            return _AppContext.Posts
                .Include(p=>p.MainComments)
               // .ThenInclude(mc=>mc.SubComments)
                .FirstOrDefault(x => x.Id == id);
        }

        public void RemovePost(int id)
        {
              _AppContext.Posts.Remove(GetPost(id));
        }

        public async Task<bool> SaveChangesAsyc()
        {
            if (await _AppContext.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }


        public void AddSubComments(SubComments comment)
        {
            _AppContext.SubComments.Add(comment);
        }

      

    }
}
