﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Beverage
    {
        // Шаблонный метод
        public void PrepareRecipe()
        {
            if (NeedBoiling())  //проверка, нужно ли кипячение 
            { 
                BoilWater(); 
            }
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected virtual bool NeedBoiling() => true; //
        protected abstract void Brew();

        protected abstract void AddCondiments();

        private void BoilWater()
        {
            Console.WriteLine("Вода закипела");
        }

        private void PourInCup()
        {
            Console.WriteLine("Напиток налит в чашку");
        }
    }
}
