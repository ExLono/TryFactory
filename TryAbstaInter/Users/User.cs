using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAbstaInter
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Balance { get; set; }
        public double Spend { get; set; }

        public User(string name, string surname, double balance, double spend)
        {
            Name = name;
            Surname = surname;
            Balance = balance;
            Spend = spend;
        }

        public void BalanceSped (double price)
        {
            Balance -= price;
            Spend += price;
        }

        public void Display()
        {
            Console.WriteLine("..................................................................");
            Console.WriteLine($"{Name} {Surname} у вас на счету {Balance}, вы потратиили {Spend}");
            Console.WriteLine("..................................................................");
        }



    }
}
