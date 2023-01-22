﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class Personel:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public Departmans Departmans { get; set; }
    }
}
