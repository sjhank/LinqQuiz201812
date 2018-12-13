﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    static class Quiz15
    {
        public static void Run()
        {
            // 請利用 departmentData 部門清單，連結 employeeData 員工清單 (如果部門沒有員工也要顯示一筆資料)，得到集合物件 query，其中包含以下資料
            // 1. Department = 部門資料
            // 2. Employee = 員工資料
            // tip. 小心 null 值
            // departmentData 內容請參考 Departments.cs (tip. 在下方 GetDepartmentsDataTable 點一下，按下 F12)
            // employeeData 內容請參考 Employees.cs (tip. 在下方 GetEmployeesDataTable 點一下，按下 F12)

            DataTable departmentData = Departments.GetDepartmentsDataTable();
            DataTable employeeData = Employees.GetEmployeesDataTable();

            // 作答區



            //// tip. 使用下方程式碼顯示資料
            //foreach (var q in query)
            //{
            //    Console.WriteLine($"Department = {q.Department["ID"]}, Employee = {q.Employee?["ID"] ?? "No Body"}");
            //}

            // 作答區

            // 執行時記得修改 Program.cs
        }
    }
}

#region 提示
// 1. 使用 AsEnumerable() 將 DataTable 轉成 IEnumerable<DataRow>
// 2. 使用 GroupJoin & SelectMany 進行外連結(Left Outer Join)，並取得部門及員工資料
//    或是使用 宣告式 的 join 寫法
#endregion