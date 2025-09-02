using StudentsManagerApp.Domain.Common;
using StudentsManagerApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Domain.Models
{
    public class Person: BaseModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public GenderType gender { get; set; }
        public string About { get; set; }


    }
}
