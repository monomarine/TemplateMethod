using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cocktail :Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Смешивание ингридиентов коктейля");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем трубочку");
        }
    }
}
