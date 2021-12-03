using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public abstract string Year { get; set;}
        public abstract string Make { get; set;} 

        public abstract string Model { get; set;}

        public abstract string DriveAbstract();

        public virtual string DriveVirtual()
        {
            return "";
        }
        

        






    }

   
}
