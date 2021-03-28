using ProjectPatterns.Command.Abstract;
using ProjectPatterns.Command.Commands;

namespace ProjectPatterns.Command
{
    public class SuperRemoteControl
    {
        private readonly ICommand[] TurnOnCommands;
        private readonly ICommand[] TurnOffCommands;

        public SuperRemoteControl()
        {
            TurnOnCommands = new ICommand[7];
            TurnOffCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();

            for(var i = 0; i < 7; i++)
            {
                TurnOnCommands[i] = noCommand;
                TurnOffCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand turnOnCommand, ICommand turnOffCommand)
        {
            TurnOnCommands[slot] = turnOnCommand;
            TurnOffCommands[slot] = turnOffCommand;
        }

        public void OnTurnOnButtonPressed(int slot)
        {
            TurnOnCommands[slot].Execute();
        }

        public void OnTurnOffButtonPressed(int slot)
        {
            TurnOffCommands[slot].Execute();
        }
    }
}
