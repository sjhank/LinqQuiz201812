using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TitleType Title { get; set; }
        public DateTime HireDate { get; set; }
        public GenderType Gender { get; set; }
        public DepartmentType Department { get; set; }
    }
}
