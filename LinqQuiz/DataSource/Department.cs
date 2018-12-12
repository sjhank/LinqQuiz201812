using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    public enum DepartmentID
    {
        A1, A2, B1, B2, B3, C1, D1
    }

    public class Department
    {
        public DepartmentID ID { get; set; }
        public string Type { get; set; }
    }
}
