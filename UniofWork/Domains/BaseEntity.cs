using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class BaseEntity
    {
        // Bu 4 alan bütün entitylerde ortak olacağı için base entity şeklinde diğer class'lar buradan miras alınacak
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool isActive { get; set; }
    }
}
