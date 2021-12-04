using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class MachineOnState : IMachineState
    {
        public void Action()
        {
            Console.WriteLine("Turning Off Machine");            
        }

        
    }
}
