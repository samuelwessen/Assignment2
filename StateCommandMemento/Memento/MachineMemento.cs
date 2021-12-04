using Assignment2.StateCommandMemento.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Memento
{
    public class MachineMemento
    {
        public MachineMemento(Machine machine, List<MachineCommand> commandList)
        {
            Machine = machine;
            CommandList = commandList;
        }

        public Machine Machine { get; set; }
        public List<MachineCommand> CommandList { get; set; }

        public void ResetMachine()
        {
            Console.WriteLine("Reseting list and turning the machine off");
            Machine.CommandList.Clear();
            Machine.MachineState = new MachineOffState();
        }
    }
}
