using DAL.Repository.Abstract;
using DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitofWork : IUnitofwork
    {
        private PersonelContext _context;
        public UnitofWork(PersonelContext context)
        {
            _context = context;
            DepartmentsRepository = new DepartmentRepository(_context);
            PersonelRepository = new PersonelRepository(_context);
        }
        public IDepartmentsRepository DepartmentsRepository { get; private set; }

        public IPersonelRepository PersonelRepository { get; private set; }

        public int Complete()
        {
           return  _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
