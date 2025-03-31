using System;

namespace ConsoleApp2
{
    public class Cocktail : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Смешивание ингредиентов коктейля");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем лёд и украшения");
        }
    }
}