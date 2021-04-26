using ProjectPatterns.Command.Abstract;
using ProjectPatterns.Command.Objects;

namespace ProjectPatterns.Command.Commands
{
    public class TurnOnStereoSystemCDCommand : ICommand
    {
        private readonly StereoSystem _stereoSystem;

        public TurnOnStereoSystemCDCommand(StereoSystem stereoSystem)
        {
            _stereoSystem = stereoSystem;
        }

        public void Execute()
        {
            _stereoSystem.TurnOn();
            _stereoSystem.SetCD();
            _stereoSystem.SetVolume(11);
        }

        public void UnExecute()
        {
            _stereoSystem.TurnOff();
        }
    }
}
