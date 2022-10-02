using System.Collections.Generic;
using System.Linq;//加入Linq可以在集合中獲得許多新方法，用來執行各種查詢
namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //人員
            var member = new[]
            {
                //資料型態是匿名型態，使用new關鍵字但不使用型態
                new{Name="Alex",No=1},
                new{Name="Bob",No=2},
                new{Name="Cindy",No=3},
                new{Name="Dora",No=4},
                new{Name="Eric",No=5},
            };
            //訂單
            var memberOrder = new[]
            {
                new{No=1,OrderNo="A001"},
                new{No=2,OrderNo="A002"},
                new{No=3,OrderNo="A003"},
                new{No=4,OrderNo="A004"},
                new{No=5,OrderNo="A005"},
                new{No=1,OrderNo="A006"},
            };
            //訂單資料合併
            var orderForm =
                from memberNo in member
                join orderNo in memberOrder //join會要求LINQ列舉兩個序列，用來匹配兩者的成員
                on memberNo.No equals orderNo.No//on後面是第一個要合併的集合，equals之後是要合併的第二個集合，合併條件是No相等
                select new //指定要回傳的資料(匿名型態)
                {
                    Name = memberNo.Name,
                    No = memberNo.No,
                    OrderNo = orderNo.OrderNo,
                };
           
            foreach(var r in orderForm)
            {
                Console.WriteLine($"訂單資料:{r}");
            }

        }


    } 
}