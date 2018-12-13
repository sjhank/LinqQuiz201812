using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    public static class Employees
    {
        public static DataTable GetEmployeesDataTable()
        {
            var Employees = GetEmployees();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("HireDate", typeof(DateTime));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Department", typeof(string));

            foreach (var emp in Employees)
            {
                dt.Rows.Add(
                    emp.ID,
                    emp.FirstName,
                    emp.LastName,
                    emp.Title.ToString(),
                    emp.HireDate,
                    emp.Gender.ToString(),
                    emp.Department.ToString());
            }

            return dt;
        }

        public static IEnumerable<Employee> GetEmployees()
        {
            yield return new Employee { ID = 001, FirstName = "Aaron", LastName = "Fisher", Title = TitleType.PM, HireDate = new DateTime(2015, 6, 1), Department = DepartmentID.A1, Gender = GenderType.Male };
            yield return new Employee { ID = 002, FirstName = "Terry", LastName = "Rossil", Title = TitleType.PM, HireDate = new DateTime(2015, 6, 1), Department = DepartmentID.B1, Gender = GenderType.Female };
            yield return new Employee { ID = 003, FirstName = "Adomm", LastName = "Silver", Title = TitleType.PM, HireDate = new DateTime(2015, 6, 1), Department = DepartmentID.A2, Gender = GenderType.Male };
            yield return new Employee { ID = 004, FirstName = "Roger", LastName = "Gachtt", Title = TitleType.PM, HireDate = new DateTime(2015, 6, 1), Department = DepartmentID.C1, Gender = GenderType.Female };
            yield return new Employee { ID = 005, FirstName = "Peter", LastName = "Ranbow", Title = TitleType.SA, HireDate = new DateTime(2015, 6, 1), Department = DepartmentID.A1, Gender = GenderType.Male };

            yield return new Employee { ID = 006, FirstName = "Iilut", LastName = "Quaker", Title = TitleType.SD, HireDate = new DateTime(2015, 7, 1), Department = DepartmentID.A1, Gender = GenderType.Female };
            yield return new Employee { ID = 007, FirstName = "Boshi", LastName = "Teally", Title = TitleType.SA, HireDate = new DateTime(2015, 7, 1), Department = DepartmentID.A2, Gender = GenderType.Male };
            yield return new Employee { ID = 008, FirstName = "Wamer", LastName = "Lushik", Title = TitleType.PM, HireDate = new DateTime(2015, 8, 1), Department = DepartmentID.B2, Gender = GenderType.Female };
            yield return new Employee { ID = 009, FirstName = "Rubby", LastName = "Pistte", Title = TitleType.PM, HireDate = new DateTime(2015, 8, 1), Department = DepartmentID.B3, Gender = GenderType.Male };
            yield return new Employee { ID = 010, FirstName = "Ooser", LastName = "Rewser", Title = TitleType.PG, HireDate = new DateTime(2015, 8, 1), Department = DepartmentID.A1, Gender = GenderType.Female };

            yield return new Employee { ID = 011, FirstName = "Lance", LastName = "Uskkey", Title = TitleType.PG, HireDate = new DateTime(2015, 9, 1), Department = DepartmentID.A1, Gender = GenderType.Male };
            yield return new Employee { ID = 012, FirstName = "Esjur", LastName = "Richer", Title = TitleType.SA, HireDate = new DateTime(2015, 9, 1), Department = DepartmentID.B1, Gender = GenderType.Female };
            yield return new Employee { ID = 013, FirstName = "Yeniz", LastName = "Ollert", Title = TitleType.SA, HireDate = new DateTime(2016, 1, 1), Department = DepartmentID.B2, Gender = GenderType.Male };
            yield return new Employee { ID = 014, FirstName = "Gench", LastName = "Persky", Title = TitleType.SA, HireDate = new DateTime(2016, 1, 1), Department = DepartmentID.C1, Gender = GenderType.Female };
            yield return new Employee { ID = 015, FirstName = "Kobee", LastName = "Uskker", Title = TitleType.SA, HireDate = new DateTime(2016, 2, 1), Department = DepartmentID.B3, Gender = GenderType.Male };

            yield return new Employee { ID = 016, FirstName = "Ameka", LastName = "Isitsu", Title = TitleType.SA, HireDate = new DateTime(2016, 2, 1), Department = DepartmentID.B1, Gender = GenderType.Female };
            yield return new Employee { ID = 017, FirstName = "Redan", LastName = "Woznik", Title = TitleType.SD, HireDate = new DateTime(2016, 2, 1), Department = DepartmentID.B3, Gender = GenderType.Male };
            yield return new Employee { ID = 018, FirstName = "Tarky", LastName = "Rashed", Title = TitleType.SD, HireDate = new DateTime(2016, 3, 1), Department = DepartmentID.C1, Gender = GenderType.Female };
            yield return new Employee { ID = 019, FirstName = "Iilut", LastName = "Rewser", Title = TitleType.SD, HireDate = new DateTime(2016, 4, 1), Department = DepartmentID.A2, Gender = GenderType.Male };
            yield return new Employee { ID = 020, FirstName = "Rubby", LastName = "Ranbow", Title = TitleType.SA, HireDate = new DateTime(2016, 4, 1), Department = DepartmentID.B2, Gender = GenderType.Female };

            yield return new Employee { ID = 021, FirstName = "Esjur", LastName = "Teally", Title = TitleType.SD, HireDate = new DateTime(2016, 5, 1), Department = DepartmentID.B2, Gender = GenderType.Female };
            yield return new Employee { ID = 022, FirstName = "Redan", LastName = "Fisher", Title = TitleType.PG, HireDate = new DateTime(2016, 7, 1), Department = DepartmentID.B1, Gender = GenderType.Male };
            yield return new Employee { ID = 023, FirstName = "Wamer", LastName = "Pistte", Title = TitleType.PG, HireDate = new DateTime(2016, 7, 1), Department = DepartmentID.B1, Gender = GenderType.Third };
            yield return new Employee { ID = 024, FirstName = "Roger", LastName = "Richer", Title = TitleType.SD, HireDate = new DateTime(2016, 7, 1), Department = DepartmentID.A2, Gender = GenderType.Male };
            yield return new Employee { ID = 025, FirstName = "Boshi", LastName = "Silver", Title = TitleType.PG, HireDate = new DateTime(2016, 7, 1), Department = DepartmentID.C1, Gender = GenderType.Female };

            yield return new Employee { ID = 026, FirstName = "Lance", LastName = "Uskker", Title = TitleType.PG, HireDate = new DateTime(2016, 7, 1), Department = DepartmentID.C1, Gender = GenderType.Male };
            yield return new Employee { ID = 027, FirstName = "Adomm", LastName = "Quaker", Title = TitleType.PG, HireDate = new DateTime(2016, 8, 1), Department = DepartmentID.B2, Gender = GenderType.Female };
            yield return new Employee { ID = 028, FirstName = "Peter", LastName = "Gachtt", Title = TitleType.PG, HireDate = new DateTime(2016, 8, 1), Department = DepartmentID.B3, Gender = GenderType.Third };
            yield return new Employee { ID = 029, FirstName = "Ooser", LastName = "Rossil", Title = TitleType.PG, HireDate = new DateTime(2016, 8, 1), Department = DepartmentID.B3, Gender = GenderType.Male };
            yield return new Employee { ID = 030, FirstName = "Rubby", LastName = "Lushik", Title = TitleType.PG, HireDate = new DateTime(2016, 9, 1), Department = DepartmentID.A2, Gender = GenderType.Female };
        }
    }
}
// 本資料純屬虛構，如有雷同，純屬巧合
