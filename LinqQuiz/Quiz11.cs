using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    static class Quiz11
    {
        public static void Run()
        {
            // 請將 Data 員工清單轉成字典 Dictionary<int, string>，key 為 ID，Value 為 FirstName
            // Data 內容請參考 Employees.cs (tip. 在下方 GetEmployeesDataTable 點一下，按下 F12)

            DataTable data = Employees.GetEmployeesDataTable();

            // 作答區



            // 作答區

            // 執行時記得修改 Program.cs
        }
    }
}

#region 提示
// 1. 使用 AsEnumerable() 將 DataTable 轉成 IEnumerable<DataRow>
// 2. 使用 ToDictionary 轉成字典
#endregion