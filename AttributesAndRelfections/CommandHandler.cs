using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributesAndRelfections
{
    internal class CommandHandler
    {
        public void ExecuteCommand(string commandName)
        {
            var AllcommandTypes = Assembly.GetExecutingAssembly().GetTypes();
            var commandTypes = AllcommandTypes.Where(t => typeof(ICommand).IsAssignableFrom(t));

            foreach (var type in commandTypes)
            {
                // Get the CommandAttribute on each class
                var attribute = type.GetCustomAttribute<CommandAttribute>();
                if (attribute != null && attribute.CommandName == commandName)
                {
                    // Create an instance of the command and execute it
                    ICommand command = (ICommand)Activator.CreateInstance(type);
                    command.Execute();
                    return;
                }
            }

            Console.WriteLine($"Command '{commandName}' not found.");
        }
    }
}
