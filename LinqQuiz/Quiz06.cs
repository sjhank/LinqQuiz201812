using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    static class Quiz06
    {
        public static void Run()
        {
            // 請取出 Data 員工清單中，Department 為 B2 的員工，並找出這些員工的 HireDate 最晚的日期 是哪一天
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
// 2. 使用 Where 取出 Department == "B2" 的員工 
// 3. 使用 Max 取得 HireDate 最大值
#endregion