using ProjectPatterns.Command.Abstract;
using ProjectPatterns.Command.Objects;

namespace ProjectPatterns.Command.Commands
{
    public class OpenGarageDoorCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public OpenGarageDoorCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Open();
        }

        public void UnExecute()
        {
            _garageDoor.Close();
        }
    }
}
