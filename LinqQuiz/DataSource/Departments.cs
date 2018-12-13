using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    public static class Departments
    {
        public static DataTable GetDepartmentsDataTable()
        {
            var departments = GetDepartments();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Type", typeof(string));

            foreach (var dep in departments)
            {
                dt.Rows.Add(
                    dep.ID.ToString(),
                    dep.Type);
            }

            return dt;
        }

        public static IEnumerable<Department> GetDepartments()
        {
            yield return new Department { ID = DepartmentID.A1, Type = "M" };
            yield return new Department { ID = DepartmentID.A2, Type = "N" };
            yield return new Department { ID = DepartmentID.B1, Type = "O" };
            yield return new Department { ID = DepartmentID.B2, Type = "W" };
            yield return new Department { ID = DepartmentID.B3, Type = "X" };
            yield return new Department { ID = DepartmentID.C1, Type = "Y" };
            yield return new Department { ID = DepartmentID.D1, Type = "Z" };
        }
    }
}
// 本資料純屬虛構，如有雷同，純屬巧合
