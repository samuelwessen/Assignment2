namespace Assignment2.StateCommandMemento
{
    internal class MachineOffState : IMachineState
    {
        public void Action()
        {
            System.Console.WriteLine("Turning On Machine");
            
        }

        
    }
}