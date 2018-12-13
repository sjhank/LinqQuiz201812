using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    static class Quiz08
    {
        public static void Run()
        {
            // 請取出 employeeData 員工清單中(假設已依照 ID 排序)，第 6 ~ 10 名員工的資料
            // 進階題: 如果有一本員工名冊(依照 ID 排序)，一頁有五個員工，如何取出某一頁的員工資料
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
// 2. 使用 Skip 和 Take 取得某一範圍的資料
#endregion