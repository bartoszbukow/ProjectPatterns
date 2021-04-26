using ProjectPatterns.Command.Abstract;
using ProjectPatterns.Command.Objects;

namespace ProjectPatterns.Command.Commands
{
    public class TurnOnLightCommand : ICommand
    {
        private readonly Light _light;

        public TurnOnLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }

        public void UnExecute()
        {
            _light.TurnOff();
        }
    }
}
