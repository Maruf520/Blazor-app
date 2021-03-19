using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter product Name!!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter product type!!")]
        public string Type { get; set; }
    }
}
