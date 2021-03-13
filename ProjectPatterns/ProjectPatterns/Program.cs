using ProjectPatterns.Inheritance;
using ProjectPatterns.Inheritance.Flying;

namespace ProjectPatterns
{
    class Program
    {
        static void Main()
        {
            Duck wild = new WildDuck();
            wild.InvokeQuack();
            wild.InvokeFly();

            Duck model = new DuckModel();
            model.InvokeFly();
            model.SetFlying(new FlyWithRocketPropulsion());
            model.InvokeFly();
        }
    }
}
