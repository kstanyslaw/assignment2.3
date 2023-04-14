using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._3
{
    internal class Teacher
    {

        public string Fio => LastName + " " + FirstName + " " + MiddleName;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Institute { get; set; }
        public Service PrefferedService;

    }
}
