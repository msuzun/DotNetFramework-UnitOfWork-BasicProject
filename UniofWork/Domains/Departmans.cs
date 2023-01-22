using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class Departmans:BaseEntity
    {
        public int Id { get; set; }
        public string Name {get; set; }
        public ICollection<Personel> Personels { get; set; }
        public Departmans()
        {
            Personels = new HashSet<Personel>();
        }
    }
    
}
