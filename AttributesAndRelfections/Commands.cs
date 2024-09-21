namespace AttributesAndRelfections
{
    [Command("Print")]
    public class PrintCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Executing Print Command!");
        }
    }

    public class SaveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Executing Save Command!");
        }
    }

    [Command("Delete")]
    public class DeleteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Executing Delete Command!");
        }
    }
}