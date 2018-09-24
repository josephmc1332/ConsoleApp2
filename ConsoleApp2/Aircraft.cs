using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Aircraft : Vehicle
    {
        public virtual void Fly()
        {
            Console.WriteLine("Aircraft is flying");
        }
        public override void Move()
        {
            Fly();
        }
        public virtual void Start()
        {
            Console.WriteLine("Aircraft engine spins up");


        }
        public virtual void Fuel()
        {
            Console.WriteLine("Filled with jp-8");
        }


        public virtual void Maintain()
        {
            Console.WriteLine("pmcs");
        }
    }
}
