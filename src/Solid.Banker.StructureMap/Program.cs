using System;
using System.Linq.Expressions;
using System.Security.Policy;
using Solid.Banker.Logging;
using StructureMap;

namespace Solid.Banker.StructureMap
{
    class Program
    {
        static void Main()
        {
            BasicExample();
            //Lifestyles();

            Console.ReadLine();
        }

        private static void Lifestyles()
        {
            var container = new Container();

            container.Configure(cfg => cfg.For<TestObject>().Use<TestObject>().Singleton());

            for (int i = 0; i < 5; i++)
            {
                var testObject = container.GetInstance<TestObject>();
                Console.WriteLine("{0}: {1}", i+1, testObject.Id);
            }
            
        }

        private static void BasicExample()
        {
            var container = new Container();

            var fileLogger = new FileLogger(@"c:\temp\log.txt");
            container.Configure(cfg =>
            {
                cfg.For<IBanker>().Use<Banker>();
                cfg.For<ILogger>().Use(fileLogger).Singleton();
                //cfg.For<ILogger>().Use<FileLogger>().Ctor<string>("path").Is(@"c:\temp\log.txt");
            });

            var banker = container.GetInstance<IBanker>();

            banker.Deposit("12345", 500);
        }
    }

    public class TestObject
    {
        public Guid Id { get; private set; }

        public TestObject()
        {
            Id = Guid.NewGuid();
        }
    }
}
