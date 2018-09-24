using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Tanks : Vehicle
    {
        public void Shoot()
        {
            Console.WriteLine("The tank goes, Booooooom");
        }
        public override void Move()
        {
            Console.WriteLine("Tank runs on treads");
        }
        public override void Start()
        {
            Console.WriteLine("You turn the mechanical switch");
        }
    
    }
}
