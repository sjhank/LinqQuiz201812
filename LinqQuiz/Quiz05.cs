using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    static class Quiz05
    {
        public static void Run()
        {
            // 請取出 employeeData 員工清單中，Title 為 PG 的員工，並依照 HireDate 由後到先排序，並取出 ID 數字，得到集合物件 query
            // employeeData 內容請參考 Employees.cs (tip. 在下方 GetEmployeesDataTable 點一下，按下 F12)

            DataTable employeeData = Employees.GetEmployeesDataTable();

            // 作答區



            // 作答區

            // 執行時記得修改 Program.cs
        }
    }
}

#region 提示
// 1. 使用 AsEnumerable() 將 DataTable 轉成 IEnumerable<DataRow>
// 2. 使用 Where 取出 Title == "PG" 的員工 
// 3. 使用 OrderByDescending 針對 HireDate 由大到小排序
// 4. 使用 Select 取出 ID
#endregion