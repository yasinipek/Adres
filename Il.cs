using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Il
    {
        public int Id { get; set; }
        public string IlAdi { get; set; }
        public ICollection<Ilce> Ilceler { get; set; } = new List<Ilce>();
    }
}
