using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    public class CommandManager
    {
        public Machine Machine { get; set; }
        public CommandManager(Machine machine)
        {
            Machine = machine;
        }

        public void Action(string userCommand)
        {
            var command = new MachineCommand(Machine, userCommand);

            if(Machine.MachineState is MachineOffState)
            {
                Machine.CommandList.Add(command);
                Console.WriteLine("The machine is off... Saving command until the machine is turned on.");
            }
            else
            {
                command.Execute();
            }
        }
    }
}
