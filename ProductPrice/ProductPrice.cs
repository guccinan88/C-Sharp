using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPrice
{
    internal class ProductPrice
    {
        public string Name { get; set; }
        public string Isbn { get; set; }
        public override string ToString() => $"{Name}:{Isbn}";

        public static readonly IEnumerable<ProductPrice> Catalog = new List<ProductPrice>
        {
            new ProductPrice{Name="C#",Isbn="A-0001"},
            new ProductPrice{Name="JavaScript",Isbn="A-0002"},
            new ProductPrice{Name="NodeJS",Isbn="A-0003"},
            new ProductPrice{Name="Oracle",Isbn="B-0001"},
            new ProductPrice{Name="MS-SQL",Isbn="B-0002"},
            new ProductPrice{Name="MongoDB",Isbn="B-0003"},
        };
        public static readonly IReadOnlyDictionary<string, decimal> Prices = new Dictionary<string, decimal>
        {
            {"A-0001",500m },
            {"A-0002",400m },
            {"A-0003",600m },
            {"B-0001",380m },
            {"B-0002",450m },
            {"B-0003",700m },
        };
    }
}
