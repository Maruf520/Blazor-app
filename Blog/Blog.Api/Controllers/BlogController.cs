using AutoMapper;
using Dtod;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories.PostRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IPostRepository _repository;
        private readonly IMapper _mapper;
        public BlogController(IPostRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        [HttpGet("allpost")]
        public ActionResult <IEnumerable<PostReadDto>> GetAllBlogPost()
        {
            var allposts = _repository.GetAllBlogPosts();
            return Ok(allposts);
        }


        [HttpGet("{id}")]
        public ActionResult <PostReadDto>GetPostById(int id)
        {
            var sinpglePost = _repository.GetBlogPostById(id);
            return Ok(sinpglePost); 
        }



        [HttpPost("createpost")]
        public ActionResult<PostCreateDto> CreatePost(PostCreateDto postCreateDto)
        {
            var post = _mapper.Map<BlogPost>(postCreateDto);

            _repository.CreateBlogPost(post);

            _repository.savechanges();

            var postReadDto = _mapper.Map<PostReadDto>(post);
            /*return CreatedAtRoute(nameof(GetPostById), new { Id = post.Id }, postReadDto);*/

            return Ok(postReadDto);
        }

   
        [HttpPut("{id}")]
        public ActionResult UpdatePost(int id, PostUpdateDto updateDto)
        {
            var post = _repository.GetBlogPostById(id);
            if(post == null)
            {
                return NotFound();
            }

            _mapper.Map(updateDto, post);

            _repository.UpdatePost(post);

            _repository.savechanges();

            return NoContent();
        }



        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
