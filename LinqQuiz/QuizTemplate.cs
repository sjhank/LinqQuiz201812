using System;
using System.Data;
using System.Linq;

namespace LinqQuiz
{
    static class QuizTemplate
    {
        public static void Run()
        {
            // 問題
            // 請取出 employeeData 員工清單的 ID 數字，得到集合物件 query

            // 資料來源
            DataTable employeeData = Employees.GetEmployeesDataTable();

            // 作答區

            // 1. 請寫出 LINQ 查詢運算式，並將查詢結果儲存在 var query 中 (寫法無標準答案)
            // 2. 如果結果為集合，請跑迴圈將結果顯示在 Console 畫面，迴圈建議使用 foreach
            //    如果結果不為集合，請直接將結果顯示在 Console 畫面
            // tips: 嘗試在寫程式時，按下 cw      再按下 TAB 兩次，得到 Console.WriteLine();
            //       嘗試在寫程式時，按下 foreach 再按下 TAB 兩次，得到 foreach 迴圈

            var query = employeeData.AsEnumerable()
                .Select(p => Convert.ToInt32(p["ID"]));

            //var query = from p in employeeData.AsEnumerable()
            //            select Convert.ToInt32(p["ID"]);

            foreach (var id in query)
            {
                Console.WriteLine(id);
            }

            // 作答區

            // 寫完程式請記得 排版 (自動排版: Ctrl + K, Ctrl + D)

            // 執行時記得修改 Program.cs
        }
    }
}

// 先試著討論或找出寫法，最後才看提示，加油~~