using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor.Models
{
    public class PostReadDto
    {
        public int Id { get; set; }
        public string Post { get; set; }
        public DateTime DateTime { get; set; }
    }
}
