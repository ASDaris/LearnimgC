using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FU
{
    public class BankTerminal
    {
        protected string id;

        public BankTerminal(string id)
        {
            this.id = id;
        }

        public virtual void Connect()
        {
            Console.WriteLine("General connecting protocol");
        }
    }

    public class Mode1XTerminal : BankTerminal // унаследование у базового класса (родителя)
    {
        public Mode1XTerminal(string id) : base(id) // вызов базового конструктора
        {
        }

        public override void Connect()
        {
            base.Connect(); // вызов и выполнение метода коннект базового класса
            Console.WriteLine("Additional action for Model X");

        }
    }
    public class Mode1YTerminal : BankTerminal // унаследование у базового класса (родителя)
    {
        public Mode1YTerminal(string id) : base(id) // вызов базового конструктора
        {
        }

        public override void Connect()
        {
            Console.WriteLine("Action for Model Y");
        }
    }
}
