using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations.Dipendenza
{

    class CoffeeMachine
    {
        public CoffeeMachine()
        {

        }

        public void makeCoffee(Coffee coffee)
        {
            Console.WriteLine($"I'm making the cofee {coffee.name}");
        }

    }
    class Coffee
    {
        public string name = "Dolce Gusto";
        public Coffee()
        {

        }

    }

}
