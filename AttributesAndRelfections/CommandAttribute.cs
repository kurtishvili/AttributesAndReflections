namespace AttributesAndRelfections
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public class CommandAttribute : Attribute
    {
        public string CommandName { get; }

        public CommandAttribute(string commandName)
        {
            CommandName = commandName;
        }
    }

}