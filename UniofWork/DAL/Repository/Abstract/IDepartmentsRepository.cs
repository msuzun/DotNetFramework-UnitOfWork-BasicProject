using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Abstract
{
    public interface IDepartmentsRepository:IRepository<Departmans> 
    {
        IEnumerable<Departmans> GetTopDepartments(int count);
        IEnumerable<Departmans> GetDepartmansWithPersonenls();
    }
}
