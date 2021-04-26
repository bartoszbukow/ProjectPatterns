using ProjectPatterns.Command.Abstract;
using ProjectPatterns.Command.Commands;

namespace ProjectPatterns.Command
{
    public class SuperRemoteControl
    {
        private readonly ICommand[] TurnOnCommands;
        private readonly ICommand[] TurnOffCommands;
        private ICommand DrawBackCommand;

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

            DrawBackCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand turnOnCommand, ICommand turnOffCommand)
        {
            TurnOnCommands[slot] = turnOnCommand;
            TurnOffCommands[slot] = turnOffCommand;
        }

        public void OnTurnOnButtonPressed(int slot)
        {
            TurnOnCommands[slot].Execute();
            DrawBackCommand = TurnOnCommands[slot];
        }

        public void OnTurnOffButtonPressed(int slot)
        {
            TurnOffCommands[slot].Execute();
            DrawBackCommand = TurnOffCommands[slot];
        }

        public void OnDrawBackButtonPressed()
        {
            DrawBackCommand.UnExecute();
        }
    }
}
