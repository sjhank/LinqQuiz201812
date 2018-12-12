﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    static class Quiz07
    {
        public static void Run()
        {
            // 請取出 Data 員工清單中，Department 為 C1 的第一個員工 (試著將該名員工的資料顯示在畫面上)
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
// 2. 使用 First / FirstOrDefault 找出 Department == "C1" 的第一個員工
//    (注意兩個方法的差別)
#endregion