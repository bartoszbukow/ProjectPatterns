
namespace ProjectPatterns.Observer.Abstract
{
    public interface ISubject
    {
        void AddObserver(IObserver o);
        void DeleteObserver(IObserver o);
        void NotifyObservers();
    }
}
