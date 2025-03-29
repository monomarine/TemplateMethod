﻿using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine();

            Beverage coffee = new Coffee();
            coffee.PrepareRecipe();

            Console.WriteLine();

            Beverage coctail = new Coctail();
            coctail.PrepareRecipe();
        }
    }
}
