using DAL.Repository.Abstract;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Concrete
{
    public class DepartmentRepository : Repository<Departmans>, IDepartmentsRepository
    {
        public DepartmentRepository(PersonelContext context):base(context)
        {

        }

        public IEnumerable<Departmans> GetDepartmansWithPersonenls()
        {
            return PersonelContext.Departmans.Include("Personel").ToList();
        }

        public IEnumerable<Departmans> GetTopDepartments(int count)
        {
            return PersonelContext.Departmans.Take(count);
        }
        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }
    }
}
