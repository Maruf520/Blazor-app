using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.PostRepositories
{
   public interface IPostRepository
    {
        bool savechanges();
        IEnumerable<BlogPost> GetAllBlogPosts();
        BlogPost GetBlogPostById(int id);
        void CreateBlogPost(BlogPost blogPost);
        void UpdatePost(BlogPost blogPost);
    }
}
