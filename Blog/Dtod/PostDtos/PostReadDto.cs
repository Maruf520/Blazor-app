using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtod
{
    public class PostReadDto
    {
        public int Id { get; set; }
        public string PostBody { get; set; }
        public DateTime Created { get; set; }
    }
}
