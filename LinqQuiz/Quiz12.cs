using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    static class Quiz12
    {
        public static void Run()
        {
            // 請將 employeeData 員工清單，依照 Department 進行分組，得到集合物件 query，其中包含以下資料
            // 1. Key = 鍵值
            // 2. Data = 屬於此鍵值的員工資料
            // employeeData 內容請參考 Employees.cs (tip. 在下方 GetEmployeesDataTable 點一下，按下 F12)

            DataTable employeeData = Employees.GetEmployeesDataTable();

            // 作答區



            //// tip. 使用下方程式碼顯示資料
            //foreach (var group in query)
            //{
            //    Console.WriteLine($"Key = {group.Key}");
            //    foreach (var emp in group.Data)
            //    {
            //        Console.WriteLine($"FirstName = {emp["FirstName"]}");
            //    }
            //}

            // 作答區

            // 執行時記得修改 Program.cs
        }
    }
}

#region 提示
// 1. 使用 AsEnumerable() 將 DataTable 轉成 IEnumerable<DataRow>
// 2. 使用 GroupBy 進行分組
// 3. 使用 Select 取出 Key & Data
#endregion