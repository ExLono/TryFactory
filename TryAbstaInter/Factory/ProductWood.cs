 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAbstaInter.FactorProduct
{
    public class ProductWood : ProductBase
    {
        public string Type { get; set; }
        public ProductWood(string name, int price, string manufacturing, string type) : base(name, price, manufacturing)
        {
            if (type.Length <= 140)
                Type = type;
            else
                Type = type.Substring(0, 140);

        }

        public override double Discount(User user)
        {
            if (user.Spend < 5000)
                return Price * 0.95;
            if (user.Spend < 10000)
                return Price * 0.85;
            return Price*0.8;

        }

        public override void Display()
        {
            Console.WriteLine($"{Name} по цене {Price}, производитель {Manufacturing}, древесина {Type}");
        }
    }
}
