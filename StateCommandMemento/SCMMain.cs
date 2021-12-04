
using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.Memento;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        

        

       
        public void Run()
        {
            var machine  = new Machine();
            var commandManager = new CommandManager(machine);
            MachineMemento machineMemento = machine.CreateMemento();
            

            Console.WriteLine("State Command Memento");
            Console.WriteLine("----------------------");
            Console.WriteLine("A: Turning Machine On/Off");
            Console.WriteLine("B: Input command strings");
            Console.WriteLine("C: Reset and turn off");
            Console.WriteLine("X: Quit Program");



            while (true)
            {
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                        machine.Action();
                        foreach (var command in machine.CommandList)
                        {
                            commandManager.Action(command.InputCommand);
                        }
                        machine.CommandList.Clear();
                        break;

                    case 'b' or 'B':  
                        Console.WriteLine("Enter a command");
                        var inputCommand = Console.ReadLine();
                        commandManager.Action(inputCommand);
                        break;

                    case 'c' or 'C':
                        Console.WriteLine("Reseting commands and turning off");
                        machineMemento.ResetMachine();                        
                        break;

                    case 'x' or 'X':
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("That is not a valid choice");
                        break;


                }


            }

            
        }
    }
}