using System.Collections.Generic;
using System.Linq;

namespace ProductPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("請輸入要查詢多少價格以上的書目: ");
                int price = int.Parse(Console.ReadLine());
                IEnumerable<ProductPrice> productPrices =
                    from p in ProductPrice.Catalog
                    where ProductPrice.Prices[p.Isbn] > price
                    orderby -ProductPrice.Prices[p.Isbn] //在排序之前加上負號會執行反向排序
                    //反向排序方式二:orderby ProductPrice.Prices[p.Isbn] descending
                    select p;

                foreach (ProductPrice p in productPrices)
                {
                    Console.WriteLine($"書名: {p.Name},價格: {ProductPrice.Prices[p.Isbn]}");
                }
                Console.WriteLine("繼續請按Enter，離開查詢視窗請輸入q");
                if (Console.ReadKey().KeyChar == 'q')
                {
                    return;
                }
            }
        }
    }
}