using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAbstaInter.Interface
{
    //Интерфейс для фабричного метода ProductBase
    interface IProduct
    {
        public string Name { get; }
        public int Price { get; }
        public string Manufacturing { get; }
        public void Display();

    }

}
