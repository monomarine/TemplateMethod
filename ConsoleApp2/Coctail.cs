using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Coctail : Beverage
    {
        protected override bool NeedBoiling() => false; //для коктейлей кипятить воду не надо 
        protected override void Brew()
        {
            Console.WriteLine("Добавляем газированную воду, затем сахар, после этого мяту и лайм");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем лёд");
        }
    }
}
