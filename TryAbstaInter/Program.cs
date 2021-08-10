using System;
using TryAbstaInter.FactorProduct;

namespace TryAbstaInter
{
    class Program
    {
        static void Main(string[] args)
        {
            int pBuy = 0;
            var Ivan = new User("Dmitriy", "Fedin", Int32.MaxValue, 0);


            var Olxa = new ProductWood("Ольха", 250, "ОАО ДождевойКарьер", "Сруб");
            var Sosna = new ProductWood("Сосна", 250, "ОАО ДождевойКарьер", "Сруб");
            var Doob = new ProductWood("Дуб", 450, "ООО Дубовый Рай", "Сруб");

            var Profile = new ProductMetall("Профиль", 1000, "ООО Норникель", 6);
            var Pprofile = new ProductMetall("П-Профиль", 800, "ОАО Мой металл", 2);
            var Hprofile = new ProductMetall("H-Профиль", 300, "ООО Сад строй", 1);

            var Sell = new Sell();

            ProductBase[] products = new ProductBase[]
            {
                Olxa,
                Sosna,
                Doob,
                Profile,
                Pprofile,
                Hprofile
            };

            while (true)
                //switch
            {
                Ivan.Display();
                
                for(int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }

                Console.WriteLine("\nВведите какой товар вы бы хотели приобрести\n");

                string str = Console.ReadLine();
                int pNum;

                if(Int32.TryParse(str, out pNum))
                {
                    pNum = Convert.ToInt32(str);
                }
                else
                {
                    Console.WriteLine("Некоректный ввод");
                    continue;
                }

                if (pNum >= 0 && pNum < products.Length)
                {
                    Console.WriteLine("\nВведите колличество товара\n");
                    string str1 = Console.ReadLine();
                    int pCount;
                    if (Int32.TryParse(str1, out pCount))
                    {
                        pCount = Convert.ToInt32(str1);
                    }
                    else
                    {
                        Console.WriteLine("Некоректный ввод");
                        continue;
                    }

                    while (pCount != 0)
                    {
                        if (products[pNum].Price < Ivan.Balance)
                        {
                            Sell.Buy(Ivan, products[pNum]);
                            pCount--;
                            pBuy++;
                            
                        }
                        else
                        {
                            Console.WriteLine($"Вы купили {pBuy} товара. У вас нету денег, зайдите в другой раз");
                            pCount = 0;
                        }
                    }
                    Console.WriteLine($"Вы купили {pBuy} {products[pNum].Name}");
                    pBuy = 0;
                }
                else
                    Console.WriteLine("Такого товара нету");
              

                Console.WriteLine();
          
            }



            
        }
    }
}
