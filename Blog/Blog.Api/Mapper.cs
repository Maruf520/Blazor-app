using AutoMapper;
using Dtod;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api
{
    public class Mapper: Profile
    {
        public Mapper()
        {
            CreateMap<BlogPost, PostReadDto>();
            CreateMap<PostCreateDto, BlogPost>();
            CreateMap<PostUpdateDto, BlogPost>();

        }
    }
}
