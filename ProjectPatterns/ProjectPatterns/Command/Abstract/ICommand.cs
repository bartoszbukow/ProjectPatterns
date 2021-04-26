
namespace ProjectPatterns.Command.Abstract
{
    public interface ICommand
    {
        public void Execute();

        public void UnExecute();
    }
}
