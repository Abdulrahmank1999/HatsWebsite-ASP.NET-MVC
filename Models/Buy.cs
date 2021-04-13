using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HatSelling.Models
{
    [Keyless]
    public class Buy
    {
        public Hat Hat { get; set; }

        public User User { get; set; }

        public string Date { get; set; }
    }
}
