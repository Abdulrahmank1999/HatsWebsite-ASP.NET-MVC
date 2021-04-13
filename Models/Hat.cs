using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HatSelling.Models
{
    public class Hat
    {
        [Key]
        public int HatId { get; set; }

        
        [Required][StringLength(50)]
        public string HatName { get; set; }

        public string Description { get; set; }

        public string ImgUrl { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
