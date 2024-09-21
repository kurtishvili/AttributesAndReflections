// See https://aka.ms/new-console-template for more information


using AttributesAndRelfections;

CommandHandler handler = new CommandHandler();

// Test with different command names
handler.ExecuteCommand("Print");
handler.ExecuteCommand("Save");
handler.ExecuteCommand("Delete");
handler.ExecuteCommand("UnknownCommand");