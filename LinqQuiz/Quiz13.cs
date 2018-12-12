using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuiz
{
    static class Quiz13
    {
        public static void Run()
        {
            // 請將以下資料的 People 提取出來，得到集合物件 query
            // 進階題: 利用 Quiz12 的結果，將各部門的員工提取出來，得到集合物件 query

            var data = new[]
            {
                new {
                    TeamID = 1,
                    People = new[] { "Alfa", "Beta" }
                },
                new {
                    TeamID = 2,
                    People = new[] { "Gamma", "Delta", "Epsilon" }
                },
                new {
                    TeamID = 3,
                    People = new[] { "Zeta", "Eta" }
                },
            };

            // 作答區



            // 作答區

            // 執行時記得修改 Program.cs
        }
    }
}

#region 提示
// 1. 使用 AsEnumerable() 將 DataTable 轉成 IEnumerable<DataRow>
// 2. 使用 SelectMany 將各個集合群組的資料放在同一個群組中
#endregion