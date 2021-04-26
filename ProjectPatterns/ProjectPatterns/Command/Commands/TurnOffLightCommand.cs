using ProjectPatterns.Command.Abstract;
using ProjectPatterns.Command.Objects;

namespace ProjectPatterns.Command.Commands
{
    public class TurnOffLightCommand : ICommand
    {
        private readonly Light _light;

        public TurnOffLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }

        public void UnExecute()
        {
            _light.TurnOn();
        }
    }
}
