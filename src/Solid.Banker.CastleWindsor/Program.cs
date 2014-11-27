using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Solid.Banker.Logging;

namespace Solid.Banker.CastleWindsor
{
    class Program
    {
        static void Main()
        {
            var container = new WindsorContainer();

            container.Register(
                Component.For<IBanker>().ImplementedBy<Banker>(),
                Component.For<ILogger>().ImplementedBy<ConsoleLogger>());

            var banker = container.Resolve<IBanker>();

            banker.Deposit("12345", 500);

            Console.ReadLine();
        }
    }
}
