using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAbstaInter
{
    class Sell
    {
        public void Buy (User user, ProductBase product)
        {
            double price = product.Discount(user);
            user.BalanceSped(price);
            Console.WriteLine($"{user.Name} купил {product.Name} на {price}.");

        }
    }
}
