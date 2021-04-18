using HatSelling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HatSelling.Services
{
    public interface IHatService
    {
        public List<Hat> GetHats();

        public bool DeleteHat(Hat H);

        public bool AddHat(Hat H);

        public Hat FindHat(int Id);

        public bool UpdateHat(Hat H);
    }
}
