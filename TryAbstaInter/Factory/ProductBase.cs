using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryAbstaInter.Interface;

namespace TryAbstaInter
{
    // Вспомогательный клас интерфейсу IProduct
    // Создаем абстракцию для последующего создания продуктов
    public abstract class ProductBase : IProduct
    {
        public string Name { get; }

        public int Price { get; }

        public string Manufacturing { get; }

        public ProductBase(string name, int price, string manufacturing)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Имя не должено быть пустым");
            }
            if (string.IsNullOrWhiteSpace(manufacturing))
            {
                throw new ArgumentNullException(nameof(manufacturing), "Фабрица не должена быть пустым");
            }
            if (price <= 0)
            {
                throw new ArgumentNullException(nameof(price), "Цена не может быть отрицательной или нулевой");
            }

            Name = name;
            Price = price;
            Manufacturing = manufacturing;
        }
        //Подсчет скидки
        public abstract double Discount(User user);
        //Вывод на экран
        public abstract void Display();

    }
}
