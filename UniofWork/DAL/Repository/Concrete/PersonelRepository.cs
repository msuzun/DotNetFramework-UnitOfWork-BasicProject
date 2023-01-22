﻿using DAL.Repository.Abstract;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Concrete
{
    public class PersonelRepository : Repository<Personel>, IPersonelRepository
    {
        public PersonelRepository(PersonelContext context):base(context)
        {

        }
        public IEnumerable<Personel> GetPersonelWithDepartmens()
        {
           return  PersonelContext.Personels.Include("Departmans").ToList();
        }
        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }
    }
}
