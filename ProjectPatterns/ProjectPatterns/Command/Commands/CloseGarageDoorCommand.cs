using ProjectPatterns.Command.Abstract;
using ProjectPatterns.Command.Objects;

namespace ProjectPatterns.Command.Commands
{
    public class CloseGarageDoorCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public CloseGarageDoorCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Close();
        }

        public void UnExecute()
        {
            _garageDoor.Open();
        }
    }
}
