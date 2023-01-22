using DAL;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitofWork unitofWork = new UnitofWork(new PersonelContext());
            unitofWork.DepartmentsRepository.Add(new Departmans() { Id=1, Name = "Bilgi İşlem",isActive = false });
            System.Console.WriteLine("Deneme");
            unitofWork.Complete();
        }
    }
}
