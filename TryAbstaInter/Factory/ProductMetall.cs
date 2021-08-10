using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAbstaInter.FactorProduct
{
    class ProductMetall : ProductBase
    {
        public int PogonMetr { get; set; }
        public ProductMetall(string name, int price, string manufacturing, int pogonMetr) : base(name, price, manufacturing)
        {
            if (pogonMetr <= 0)
            {
                throw new ArgumentNullException(nameof(price), "Метр не может быть отрицательной или нулевой");
            }

            PogonMetr = pogonMetr;
        }

        public override double Discount(User user)
        {
            if (user.Spend < 5000)
                return Price * 0.99;
            if (user.Spend < 10000)
                return Price * 0.97;
            return Price * 0.94;
        }

        public override void Display()
        {
            Console.WriteLine($"{Name} по цене {Price}, производитель {Manufacturing}, погонный метр {PogonMetr}");
        }
    }
}
