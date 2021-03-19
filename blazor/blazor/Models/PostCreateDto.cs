using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blazor.Models
{
    public class PostCreateDto
    {
        [Required(ErrorMessage ="Please enter your text.")]
        public string ? PostBody { get; set; }
        [Required(ErrorMessage = "Please enter your date.")]
        public DateTime ? Created { get; set; }
    }
}
