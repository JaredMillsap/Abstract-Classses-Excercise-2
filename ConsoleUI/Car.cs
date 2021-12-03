using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
   public abstract  class Car : Vehicle
    {
        public abstract string HasTrunk { get; set; }
       int firstcar = 0;
        
        static  Car()
        {
           Vehicle Car1 = new Car();

        }

    }
}
