using Associations.Aggregazione;
using Associations.Composizione;
using Associations.Dipendenza;
using System;

namespace Associations
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Dipendenza  
            // L'oggetto di tipo CoffeeMachine NON HA bisogno dell'oggetto COFFEE per la sua creazione
            // ma per svolgere la sua funzione,

            Coffee DolceGusto = new Coffee();

            CoffeeMachine MachineDolceGusto = new CoffeeMachine();
            MachineDolceGusto.makeCoffee(DolceGusto);




            // Aggregazione 
            // L'oggetto di tipo MANAGER nasce FUORI la classe EMPLOYEE,
            // ma IL TIPO MANAGER è fondamentale per la creazione DELL'OGGETTO  EMPLOYEE
            Manager Bruno = new Manager();
            Employee aLEX = new Employee(Bruno, "Alex");

            Manager mARIO = new Manager();

            aLEX.ChangeManager(mARIO);

            mARIO.PrintStipendio();




            // Composizione 
            // L'oggetto di tipo CEO nasce dentro la classe Company 
            Company company = new Company("Bruno Ferreira");



            /// Ereditarietà
            Labor labor = new Labor();





        }
    }
}
