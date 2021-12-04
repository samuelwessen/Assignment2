using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    public class MachineCommand : ICommand
    {
        public MachineCommand(IMachine machine, string inputCommand)
        {
            Machine = machine;
            InputCommand = inputCommand;
        }

        public IMachine Machine { get; set; }
        public string InputCommand { get; set; }      


        public void Execute()
        {
            Machine.Print(InputCommand);
        }
    }
}
