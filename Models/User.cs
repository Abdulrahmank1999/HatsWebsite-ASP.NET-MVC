using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HatSelling.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required][StringLength(50)]
        public int UserName { get; set; }

        [Required][StringLength(50)]
        public string Email { get; set; }

        [Required][StringLength(50)]
        public string Password { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
