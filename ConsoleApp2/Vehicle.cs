using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("vehicle moves");
        }
    public virtual void Start()
        {
        Console.WriteLine( "you shorted the starter with a wrench");


        }
       public virtual void Fuel()
        {
            Console.WriteLine("Full of fuel");
        }


       public virtual void Maintain()
    {
            Console.WriteLine("pmcs");
    }

    }
}
