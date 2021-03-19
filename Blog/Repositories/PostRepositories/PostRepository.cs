using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.PostRepositories
{
    public class PostRepository : IPostRepository
    {

        private readonly BlogContext _context;
        public PostRepository(BlogContext context)
        {
            _context = context;
        }
        public void CreateBlogPost(BlogPost blogPost)
        {
            if (blogPost == null)
            {
                throw new ArgumentNullException(nameof(blogPost));
            }
            _context.Add(blogPost);
        }

        public IEnumerable<BlogPost> GetAllBlogPosts()
        {
            return _context.blogPosts.ToList();
        }

        public BlogPost GetBlogPostById(int id)
        {
            var post = _context.blogPosts.FirstOrDefault(c => c.Id == id);
            return post;
        }

        public bool savechanges()
        {
            return (_context.SaveChanges() >= 0);
        }


        public void UpdatePost(BlogPost blogPost)
        {
            //
        }
    }
}
