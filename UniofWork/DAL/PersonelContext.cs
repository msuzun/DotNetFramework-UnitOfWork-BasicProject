using Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonelContext : DbContext
    {
        public PersonelContext() : base("PersonelContext")
        {
        }

        public DbSet<Personel> Personels { get; set; }
        public DbSet<Departmans> Departmans { get; set; }
    }

}
