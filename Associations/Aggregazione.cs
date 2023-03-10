using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations.Aggregazione
{
    class Labor
    {
        protected string contratto;
        public decimal stipendio = 2000;
    }
    class Manager : Labor
    {
        public new decimal stipendio = 1000M;
        public Employee _employee;
        public Manager()
        {

        }
        public void AddEmployee(Employee employee)
        {
            _employee = employee;


        }
        public void RemoveEmployee(Employee employee)
        {
            _employee = null;
        }

        public void PrintStipendio()
        {
            Console.WriteLine($"Stipendio classe padre:{base.stipendio}");
            Console.WriteLine($"Stipendio classe figla: {this.stipendio} ");
        }



    }
    class Employee : Labor
    {
        private Manager _manager;
        private string _name;

        public Employee(Manager manager, string Name)
        {
            _name = Name; //Alex
            this._manager = manager;
            manager.AddEmployee(this);


        }

        public void ChangeManager(Manager manager)
        {
            this._manager.RemoveEmployee(this);
            this._manager = manager;//  il cambio manager 
        }
    }

}
