using ProjectPatterns.Command.Abstract;

namespace ProjectPatterns.Command
{
    public class MiniRemoteControl
    {
        ICommand slot;

        public MiniRemoteControl() { }

        public void SetCommand(ICommand command)
        {
            slot = command;
        }

        public void ButtonHasBeenPressed()
        {
            slot.Execute();
        }
    }
}
