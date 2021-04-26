using ProjectPatterns.Command.Abstract;
using ProjectPatterns.Command.Objects;

namespace ProjectPatterns.Command.Commands
{
    public class TurnOffStereoSystemCDCommand : ICommand
    {
        private readonly StereoSystem _stereoSystem;

        public TurnOffStereoSystemCDCommand(StereoSystem stereoSystem)
        {
            _stereoSystem = stereoSystem;
        }

        public void Execute()
        {
            _stereoSystem.TurnOff();
        }

        public void UnExecute()
        {
            _stereoSystem.TurnOn();
            _stereoSystem.SetCD();
            _stereoSystem.SetVolume(11);
        }
    }
}
