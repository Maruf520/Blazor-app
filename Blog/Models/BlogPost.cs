using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string PostBody { get; set; }
        public DateTime Created { get; set; }
    }
}
