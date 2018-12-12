using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    static class Quiz09
    {
        public static void Run()
        {
            // 請查詢 Data 員工清單中，是否存在 HireDate 為 2016 年 6 月的員工
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
// 2. 使用 Any 判斷是否有符合條件的資料
#endregion