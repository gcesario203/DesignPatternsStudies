using Implementation.SmartHouse.Interfaces;

namespace Implementation.SmartHouse
{
    public class SmartHouse
    {
        private IDictionary<string, ISmartHouseCommand> _commands = new Dictionary<string, ISmartHouseCommand>();

        public void AddCommand(ISmartHouseCommand command)
        {
            var commandToInsertKey = command.GetType().Name;

            if (_commands.Any(existingCommand => existingCommand.Key == commandToInsertKey))
                return;

            _commands.Add(commandToInsertKey, command);
        }

        public void ExecuteCommand(ISmartHouseCommand command)
        {
            var commandKey = command.GetType().Name;

            if (!_commands.Any(existingCommand => existingCommand.Key == commandKey))
                return;

            _commands[commandKey].Execute();
        }
        public void UndoCommand(ISmartHouseCommand command)
        {
            var commandKey = command.GetType().Name;

            if (!_commands.Any(existingCommand => existingCommand.Key == commandKey))
                return;

            _commands[commandKey].Undo();
        }
    }
}